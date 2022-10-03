#National Lost vehicle Form

Table of Contents

1.	Chapter: Introduction………………………………………………………………1
Implementation……………………………………………………………………….1
Forms description…………………………………………………………………….1

2.	Chapter 2: Forms Description………………………………………………….......2
Desktop Application Interface……………………………………………………...2
i.	Explanation and Illustration of Forms…………………………………….2
Client Information class………………………………………………………3
Vehicle information class…………………………………………………….3
Incident information class……………………………………………………3
Output Class ………………………………………………………………….4


3.	Chapter 3: Conclusion………………………………………………………………5
Future Suggestions……………………………………………………………………5
Conclusion…………………………………………………………………………....5

 
INTRODUCTION:
In Pakistan there is no proper lost cars claim company. We here took an initiative to bring up such a desktop application where the company gets missing cars from different areas of the country. When a client claims that his car is lost by providing his credentials and the FIR he filed at the police station, the company checks whether the information about the vehicle entered by the client is already available is the missing cars database. 

IMPLEMENTATION:  
We tried the best ways to provide an interface to applicant by using one of the best database management systems i.e. SQL server for maintaining the database and visual studio 2019 to prepare the forms 

FORMS DESCRIPTION:
	Firstly, the client needs to enter his personal information so that the company can contact him in case of vehicle recovery.
 ![image](https://user-images.githubusercontent.com/71806699/193584793-598541ea-480f-413c-8f07-ed2ccd3a8467.png)




	Secondly, by switching the tab, client needs to enter the information about the vehicle so the company can check whether they contain the car or not.
 ![image](https://user-images.githubusercontent.com/71806699/193584820-58ba11a6-a694-443d-8d47-9ce8b669d377.png)


	Thirdly, the switching the tab, client needs to enter the information about the incident and the FIR filed for the lost vehicle.
 ![image](https://user-images.githubusercontent.com/71806699/193584852-7de9fc9c-5c0a-4987-bfb8-90c3b21e9dff.png)





	In the fourth tab, all the data applicant entered can be viewed to double check if any information needs to be changed.
 ![image](https://user-images.githubusercontent.com/71806699/193584897-d183d072-3f50-4337-9173-6df1590eb76c.png)

The created forms on visual studio are connected to SQL database named ‘lost vehicles’. Through this we can store data in SQL by entering in the forms. Below are the tables created after entering data.
  
 ![image](https://user-images.githubusercontent.com/71806699/193584934-0fef57d3-00db-4a14-988b-76f1d70163d2.png)
![image](https://user-images.githubusercontent.com/71806699/193584957-244456f4-53d1-4de9-852b-c9884565302d.png)
![image](https://user-images.githubusercontent.com/71806699/193584978-99821ef8-08f8-4956-bdc9-f99ca45d6ff3.png)

 

MECHANISM:
The mechanism we used to achieve this goal of comparing is by using keys. 
CNIC no. of the client is made primary key so that the company can keep record of data. The main part is the comparison of company name, and chassis no. of the vehicle if these two are matched then a prompt message will be shown to the client saying, “the vehicle is found”. 
OUTPUT: 
The system will prompt the user in case of found car.
![image](https://user-images.githubusercontent.com/71806699/193585016-c3fb22f2-44fa-4794-8ca8-3e88215ab695.png)

 





FUTURE SUGGESTIONS: 
We will be adding more features to the desktop applications, like checking the
validity of the CNIC if it exists or not. Sending an email to the client too as a more efficient way to communicate and keep track of the deals. Thirdly and lastly, we will add the payment feature client will be paying for the services they availed.









