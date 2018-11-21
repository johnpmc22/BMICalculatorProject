# BMICalculatorProject
MSC CI/CD Pipeline project 2018
Institute of Technology Tallaght, Department of Computing
M.Sc. in Dev-Ops
2018/2019

Continuous Software Deployment

CA1 Project
Out: 11/10/2018
Due: 03/12/2018
Value: 65%

Lecturer: Gary Clynch

CI/CD

Blood pressure is measured as ‘systolic pressure’ over ‘diastolic pressure’, the unit of measure being mmHG. For example, a reading of 100 / 80 indicates a blood pressure with a systolic pressure of 100 over a diastolic pressure of 80. For the purpose of this application, systolic pressure can range from 70 to 190, and diastolic from 40 to 100. Systolic pressure is always higher than diastolic pressure.

A blood pressure reading can be used to categorise the blood pressure of the patient as low blood pressure, ideal blood pressure, pre-high blood pressure, or high blood pressure. This figure below shows how the category can be calculated:

https://www.google.ie/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjPwLzF1ubeAhVrBcAKHQGfA-IQjRx6BAgBEAU&url=http%3A%2F%2Fwww.bloodpressureuk.org%2FBloodPressureandyou%2FThebasics%2FBloodpressurechart&psig=AOvVaw3K9x39Q6numFLlcxKNNven&ust=1542930599554232

https://www.google.ie/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjfiOnS1ubeAhVlDsAKHQvhBbUQjRx6BAgBEAU&url=https%3A%2F%2Fwww.shutterstock.com%2Fimage-vector%2Fblood-pressure-chart-796872802&psig=AOvVaw3K9x39Q6numFLlcxKNNven&ust=1542930599554232

In the above figure (linked) consider the lower limits to be inclusive in the category e.g. a systolic value of 140 or greater indicates high blood pressure.  

Source code for a simple Blood Pressure Category  calculator implemented in ASP.Net Core Razor pages can be seen here https://github.com/gclynch/bp

The code is incomplete with respect to the logic to calculate the blood pressure category.

1.	Clone the  BMI application into your own VCS repository
2.	Complete the logic to calculate the blood pressure category
3.	Write some unit tests using a unit testing framework of your choice. Aim for code coverage of at least 80%.
4.	Write some user acceptance tests using Selenium – 3 tests will suffice
5.	Add telemetry tracking to the application e.g. Application Insights
6.	Design and develop a CI/CD pipeline using Azure DevOps (or another CI/CD tool) which:
a.	Builds the project continuously
i.	As part of the build run the unit tests
ii.	Runs the code through some code analysis for quality purposes – and does not proceed unless certain quality criteria are met
b.	Release the project through a release management process once a build has completed
i.	Deploy to a public cloud e.g. Azure using the App Service
ii.	Run the Selenium user acceptance tests
iii.	Deploy using blue/green scenario if the user acceptance tests pass
iv.	If a performance test passes then deploy from blue to green and vice versa
v.	Implement authorisation gates if appropriate
vi.	Monitor telemetry information
7.	Fix and code quality issues/bugs found/performance issues. 
8.	Add one new feature (with appropriate tests) and commit to the pipeline, fix any bugs. The new feature should be max 30 lines of code. Use a feature branch.

Deliverables: 
1.	Demo of code running or whatever has been achieved
2.	Hand in hard copy of source code
3.	Report describing the:
a.	CI/CD pipeline (including tests etc.), design philosophy
b.	The new feature (e.g. a user story)


