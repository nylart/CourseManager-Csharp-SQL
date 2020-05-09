# CourseManager-Csharp-SQL

Summary: Project to get accustomed to Microsoft SQL Server. Creates a database of student information and course information. 
Creates and sends and excel sheet 
Requirements:

    Microsoft Visual Studio
    Microsoft SQL Server Management Studio

Instructions:

1. Open Microsoft SQL Server Management Studio
2. Set the Server name as "localhost".
3. Press "Connect".
4. Open the "Setup Query.sql" file in the program.
5.  Execute. This will add the entries into the database.
6.  Open Microsoft Visual Studio.
7.  Open the "CourseReportEmailer.sln" solution file.
8.  Click View > Server Explorer, then right-click "Data Connections".
9.  Click "Add Connection".
10. Set the Server name as "localhost".
11. Under "Connect to a database", select the "CourseReport" database.
12. Click "Ok"
13. Open the file "EnrollmentDetailReportEmailSender.cs" and replace the [YOUR EMAIL], [YOUR PASSWORD], [RECEIVER EMAIL] with the appropriate text. It needs to be a valid email in order to work.
This is obviously not good or safe, but for quick testing purposes I left it at that, since the purpose of this project is to get more experience with SQL.
14. Execute the program.
