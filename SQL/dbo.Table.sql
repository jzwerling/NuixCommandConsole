CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [remoteNodeName] NVARCHAR(MAX) NULL, 
    [remoteNodeBaseUrl] NVARCHAR(MAX) NULL, 
    [remoteNodeUsername] NVARCHAR(MAX) NULL, 
    [remoteNodePassword] NVARCHAR(MAX) NULL, 
    [remoteNodeLicenseShortName] NVARCHAR(MAX) NULL, 
    [remoteNodeLicenseDescription] NVARCHAR(MAX) NULL, 
    [remoteNodeWorkers] INT NULL
)
