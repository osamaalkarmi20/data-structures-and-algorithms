# CAMPEE

## About CAMPEE

The main focus of our platform is to make a simple AdminDashboard for adminsters and editors for a camping e-commarce web app that will be a user friendly and easy to mange the products and the categories for the the website .
  And make a user friendly  interface for the users and to make them able to contact with the support team and purchase  any product from the website.
## Erd part1

![erdP1](./Camping/readmeAssets/lab26erd.PNG)


## Erd part2

![erdP1](./Camping/readmeAssets/Ecommercerd.PNG)

## User Story 1:  Admin Management

As Admin, I want to be able to view and manage my e-commarice shop, so that I can efficiently organize my shop for better service to my users(Clints).

###  Feature Tasks:

#### 1. Display a list of  Categories.
#### 2. Can search as Admin for a specific categories.
#### 3. Can delete and add and edit Categories.
#### 4. Display a list of  Products.
#### 5. Can search as Admin for a specific Products.
#### 6. Can delete and add and edit Products.
#### 7.I will receive a copy of all purchases emailed to our sales department so that they can update our accounting system

## User Story 2:  Editor

As Editor, I want to be able to view and Edit things e-commarice shop.

###  Feature Tasks:

#### 1. Display a list of  Categories.
#### 2. Can search as Editor for a specific categories.
#### 3. Can edit Categories.
#### 4. Display a list of  Products.
#### 5. Can search as Editor for a specific Products.
#### 6. Can edit Products.
#### 7. I receive like a copy of all purchases emailed to our warehouse so that they can begin the fulfillment process

## User Story 3: Customer

As Customer, I want to be able to view  e-commarice shop and all its products, so that I can efficiently purchase and add the them to my cart and order them to my address. 

###  Feature Tasks:
#### 1. I would be able to see products available for sale so that I can browse through the inventory for purchase.
#### 2. I would be able to register for an account on the site, so that I can make purchases
#### 3. I  would be able to securely login to my account so that I can add products to my shopping cart
#### 4. I would like a way to store the items I wish to purchase in a cart within the application.
#### 5. I  would be able to have the ability to view my desired purchases while browsing the other products on the site.
#### 6. I would be able to dedicated page where I can view all the products I wish to purpose all in one location.
#### 7. I  would be able to see a summary of my purchase after completing my checkout process.
#### 8. I  would be able to see  a summary of my purchase to be emailed to me so that I can store the receipt for my records.
#### 9. I would like to be thanked for my purchase following completion of order processing.


## Scope (In)

Our application will  provide adding and remove categories and manage the products and quantities  for each product also the can Uploud the images for the products and Edite them at any time for admins
And will provide  for useres the easies way to find products for Camping. in addition the app will provide a customer interface and the customers can buy products and and add cart and veiw all products send emails to there loggin email for there purchases 
also thay can send any suggestions or complains to the admin also to sort and filter the shop page. and also search for a product .
## Scope (Out)

Our application will not provide any products that are not for the camping industry and any fire guns for hunters.

## Minimum Viable Product (MVP)

- Admin can register on our platform as a Admin or as a Editor .
- Admin can search for categories .
- Admin can search  for a product .
- Admin can Add and remove categories and products.
- Admin can edit and view details for  categories and products.
- Editors can edited products .
- not resgerstered users can see all porduct but cant add them to cart .
- user can login and sign up.
- user can add to cart.
- user can view all the the products.
- user can view all the the products that they add to the wish list.
- user can make a perchase after seeing his sammary.
- user can fill the data of the order after the purchase .
- user will recive if the order is don fully a confirm message that his order had been taken and he will recive 2 emails one  for the invoice and the other as a thank you message.


## Technologies

- Programming Language: C#
- Framework: ASP.NET  MVC Core
- Identity Framework
- Database: Microsoft SQL Server
- Unit Testing: xUnit
- Deployment: Azure
- Manging branches:Azure dev ops
- Manging branches:Azure dev ops
- brevo Api for email sending
- Stripe.net for the payment method

## Tools

- For Communication:Discord, Slack
- IDE: Visual Studio

## Non-Functional Requirements

### Security

- All user data will be encrypted and securely stored in the database using industry-standard encryption algorithms.
- Authentication and authorization will be implemented to ensure only authorized users can access certain features.

### Usability

- The user interface will be designed with user-friendliness in mind, offering intuitive navigation and clear instructions.
- Accessibility: features will be included to accommodate users with disabilities.
- Availability: it allows the user to use the system whenever he wishes and whenever he wants.

## Tests

1. Test all the CRUD opreations for  the products and categories .
2. Test the uploading Images methods to the Azure blob.

 ## Test Results

![testP1](./Camping/readmeAssets/testEcommerceP2.PNG)



