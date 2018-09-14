# AspNetCore Template

## Get started

The SPA is located under the `app` folder.

Then to start the dev server, run this command:

`npm run dev`

Fire up the AspNetCore app from Visual Studio and browse to `http://locahost:5000`

## Evaluation Process

### For admin

1. Create a new branch `git checkout -b candidates/<UNIQUE_CANDIDATE_ID>`
2. Push to the remote `git push origin --all`
3. Communicate the `<UNIQUE_CANDIDATE_ID>` with the candidate

### For the candidate

1. Fork the repo
2. Make the changes on the `candidates/<UNIQUE_CANDIDATE_ID>`
3. Create a pull request to the original repo, on the above same branch
4. Notify the admin

## Khanh Trinh notes

### Assumption 
1. No validation is implemented so the data file, .csv, should in the same format as the provided file.
2. Server side code is using .Net Core and Web API. Not using dependency injection but the code is ready for applly it.
3. Data file is stored in "Data" folder and get from the configuration "DataFilePath" in "appsettings.json" file.
4. Client side code is using Vue2, Vue-router, Buefy/Bulma. Using Vue-router to add more features easily. Using Buefy/Bulma to build UI faster.

### Usage
1. At Seach page, click on "Acme Contact Management" to turn back Contact list page.
2. Click at the begining of every row to see its detail. Need to improve by adding icons.
3. Support sort for everry column but no signal to know which colum is sorted currently. Need to improve by adding icons.

### Development timeline
1.  Preparation - 1.5 hour
1.	Read and parse csv file to object. - 1.5 hours
2.	Build web apis for accessing data from client. - 1 hours
3.	Build a scalable structure for client app and for developing easily and quickly. - 5 hours
4.	Build the contact management page that have some functions: 5.5 hours
  -	Show all contact items - 2 hours
  -	Sorting - 0.5 hour
  -	Paging - 1 hour
  -	Show contact detail for selected row - 2 hours
5.	Build the search page (refer to contact management page). - 1 hour
6. UI Styling - 4 hour
7. Testing - 0.5 hour
8. Document (Read me page)  - 0.5 hour


