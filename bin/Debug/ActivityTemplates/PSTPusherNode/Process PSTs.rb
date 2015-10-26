#encoding: UTF-8
#Menu Title: Process PSTs

def load_lib(name)
	puts "Loading #{name}"
	load "#{File.dirname(__FILE__)}\\#{name}"
end

java_import java.lang.System
load_lib("System_Properties.rb_")
load_lib("PSTProcessor.rb_")
load_lib("PSTSearch.rb_")
#load_lib("EvidenceContainerSettings.rb_")
load_lib("ProcessorSettings.rb_")
#load_lib("ParallelProcessingSettings.rb_")
load_lib("SwingDialogs.rb_")
#load_lib("ScriptSettings.rb_")
load_lib("ProgressDialog.jar")
java_import 'com.nuix.nx.dialogs.ProgressDialog'
java_import javax.swing.JOptionPane
$flag_cancelled = false

#add event to catch to shut down script if user cancels the processing dialog
def returnScriptWithMessage(message, title)
	JOptionPane.showMessageDialog(nil,message,title,JOptionPane::PLAIN_MESSAGE) if !$flag_cancelled
	$flag_cancelled = true
end

def writeReport(name, filename, content)
#Just takes an array of data (formatted to CSV already in my functions) and dumps it to a file on disk, used to spit out the various CSV reports and config files
	report_file = File.new("#{filename}", "w+")
	report_file.puts content
	report_file.close
	puts "#{name}: #{filename}"
end  

# get location of pst files
pst_location = choose_dir("Select location of PST files") unless $flag_cancelled
returnScriptWithMessage("User Cancelled", "Script cancelled.") if pst_location == nil
returnScriptWithMessage("No such directory found, script cancelled", "Error found") unless Dir.exists?(pst_location)

return "cancelled" if $flag_cancelled
pp= PSTProcessor.new(pst_location)
#use this to skip reporting on total size - i.e. data used for progress bars.
pp.setTotalSizeReported(true)
def final_comments(dialog, success)
	success ? dialog.logMessage("Process Completed.") : dialog.logMessage("Process Cancelled")
	#dialog.setMainStatus("Finished.")
end

ProgressDialog.forBlock do |dialog|
	dialog.setAlwaysOnTop(false)
	dialog.setSubProgressVisible(false)
	dialog.setTitle("Process PST Files")
	final_comments(dialog, pp.processPSTs(dialog))
end


return 7