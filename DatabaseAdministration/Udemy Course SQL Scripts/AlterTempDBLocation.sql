USE master;
Go

ALTER Database tempdb
MODIFY FILE (Name = tempdev, Filename = 'EnterNewLocation');
Go