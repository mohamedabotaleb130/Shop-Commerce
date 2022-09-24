# onlineshoping
Overview

Project Description
ShopCommerce is a scalable micro-marketplace project using Asp.Net Core technology and built on a multi-layer architecture.

Layers

1-) Entity Layer
Layer where database objects are saved
2-) Data access layer
It is the layer in which database CRUD operations are performed.
3-) Business Layer
It is the layer where the business rules for the project are written.
4-) User Interface
It is the user interface layer of the project.
In this project, interface mvc technology is used.
3. Types of Users There are 3 types of users in the system.
1-) Regular Users (Users)
Everyone can enter the necessary information like email etc into the system, to become a member and start shopping.
2-) Sellers
Those wishing to create a store in the system and conduct sales can enter the system, add products and start selling if approved after entering the necessary information and submitting the form.
Sellers who create stores can add other sellers to their stores.
3-) Supervisors (Supervisors)
In the system, administrators are separated according to their roles and have different powers. Not everyone can be a manager. There is a "global administrator" in the system and can add or block administrators according to their roles.
4-) Operation
The user can enter the system without being a member, and browse the allowed pages to check out the products.
The user must be a member of the system to purchase products.
After the user becomes a member, a special basket is created for the user and the user can add products there and continue to buy later.
User can give likes to products and watch them later.
An order tracking page has been added to the project, where the user can track the ordered products.
After the user orders the product, he can cancel the products that have not been shipped. Delivered products can be sent back.
A search page (/store) has been added so that users can easily search for products, without refreshing the page, by the selected category, price range and - or brand filters.
Ajax technology is used to search for the product. This results in a better user experience.
Sellers enter the necessary information and create a store in the system.
The seller can add products, edit his products, delete his products and modify his private information from the private admin panel.
The product images added by the seller are added under the /wwwroot/Images/
The added product will be accessible to users after the approval of the administrator.
The user can list products in a store, but more than one seller can be added to the store.
When the user places an order, the products in the order are entered on the order page of that seller by the seller. (/ seller/ orders)
Multiple products can be added to the order
More than one seller's products can be added to the order.
The user can order a product up to the maximum number of shares.
managers
Administrators can be added based on their role.
The authority to add an admin rests with the Global Administrator.
They are the top officials in the system.
When the sellers want to create a store in the system, these sellers can log into the system after the approval of the general administrator of these stores and sellers.
The public administrator can block sellers and stores.
5. Database
In the project, mssql server 2019 was preferred as the database management system.
