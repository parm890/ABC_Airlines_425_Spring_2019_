CREATE TABLE [dbo].[Intinerary]
(
	[Reference Number] INT NOT NULL PRIMARY KEY, 
    [Flight number] NCHAR(10) NOT NULL, 
    [Flight Departure Time1] NCHAR(10) NOT NULL, 
    [Flight Arrival Time1] NCHAR(10) NOT NULL, 
    [Departure date] NCHAR(10) NOT NULL, 
    [Arrival date] NCHAR(10) NOT NULL, 
    [Departure location] NCHAR(10) NOT NULL, 
    [Time of flight] NCHAR(10) NOT NULL
    
)
