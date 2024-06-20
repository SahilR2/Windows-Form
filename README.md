# Windows Form Application - SlidelyAi Task
This project is a Windows Desktop Application built using Visual Studio with the Visual Basic language. The application allows users to create new submissions and view existing submissions.

## Prerequisites
<pre>
- Visual Studio (2019 or later) with .NET desktop development workload installed.
- .NET Framework 4.7.2 or later.
</pre>

## Project Structure
### MainForm.vb: 
 - The main form with buttons to navigate to "Create New Submission" and "View Submissions" forms.
 
![Screenshot 2024-06-20 215433](https://github.com/SahilR2/Windows-Form/assets/139258098/67d0a5e6-21b9-4936-b1e1-8ca85ac15c2f)
 

### CreateSubmissionsForm.vb:
- Form to create new submissions, including fields for Name, Email, Phone Number, GitHub link, and a stopwatch.

![Screenshot 2024-06-20 215528](https://github.com/SahilR2/Windows-Form/assets/139258098/9147312d-9e9c-467d-94ee-17cede40dc2f)
 
 
### ViewSubmissionsForm.vb:
 - Form to view submissions, delete submissions and navigate through them.

![Screenshot 2024-06-20 215502](https://github.com/SahilR2/Windows-Form/assets/139258098/e69f108d-8271-4398-be01-32fccde2d280)

 
### ApiClient.vb:
 - Contains methods to interact with the API to fetch and submit submission data.
### Submission.vb: 
 - Model class representing a submission object.
 
