# Online Book Store
 Bitbucket Repository Link:
https://bitbucket.org/oop2-group/online-book-store-oop2-proje/src/develop/

## [1. INTRODUCTION](https://github.com/ismaildemircann/OnlineBookStore#1-introduction-1)
## [2. DESIGN](https://github.com/ismaildemircann/OnlineBookStore#2-design-1)
### [2.1. UML](https://github.com/ismaildemircann/OnlineBookStore#21-uml)
### [2.2. SAMPLE OUTPUT OF PROGRAM FOR SAMPLE INPUT](https://github.com/ismaildemircann/OnlineBookStore#22-sample-output-of-program-for-sample-input)
### [2.3. DESIGN PATTERN DESCRIPTION](https://github.com/ismaildemircann/OnlineBookStore#23-design-pattern-description)
## [3. Authors](https://github.com/ismaildemircann/OnlineBookStore#3-authors)
## 1. INTRODUCTION
The project’s purpose is to gain the shopping experience to customer. The project’s idea is to
purchase product from online shopping application. The customer logins to the application with
username and password. The customer can examine product and it’s properties
(name,price,piece that received ) after login. The customer can add product as many products
as wants also can remove products from shopping cart. The customer can choose one of from
cash,credit card or transfer/EFT for payment . The customer can choose delivery address. The
customer must enter verification code that sent to e-mail address. Therefore the customer should
enter correct e-mail address. The customer’s invoice will sent to customer’s e-mail address in
.pdf format. The customer can see cargo status and can see old orders.

## 2. DESIGN
### 2.1. UML
![Uml-img](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/UML.png)
### 2.2. SAMPLE OUTPUT OF PROGRAM FOR SAMPLE INPUT 
![Sign Up Screen](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/SIGN%20UP%20SCREEN.png)

#### SIGN UP SCREEN

This screen provides us sign up to the application
<hr>


![Login Screen](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/LOGIN%20SCREEN.png)

#### LOGIN SCREEN

This screen provides us login to the application
<hr>


![Books Screen](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/BOOKS%20SCREEN.png)

#### BOOKS SCREEN

This screen provides us list of books
<hr>


![Shopping List](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/SHOPPING%20LIST.png)

#### SHOPPING LIST

This screen shows shopping cart
<hr>


![Payment Screen](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/PAYMENT%20SCREEN.png)

#### PAYMENT SCREEN

This screen shows payment operations 
<hr>


![VERIFICATION CODE IN MAIL](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/VERIFICATION%20CODE%20IN%20MAIL.png)

#### VERIFICATION CODE IN MAIL

This screen shows verification code that sent to the e-mail
<hr>


![INVOICE PDF FILE IN MAIL](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/INVOICE%20PDF%20FILE%20IN%20MAIL.png)

#### INVOICE PDF FILE IN MAIL

This screen shows invoice information that sent to the e-mail
<hr>


![MY ORDERS SCREEN](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/MY%20ORDERS%20SCREEN.png)

#### MY ORDERS SCREEN

This screen shows orders belong to customer
<hr>


![ADMIN BOOKS SCREEN](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/ADMIN%20BOOKS%20SCREEN.png)

#### ADMIN BOOKS SCREEN

In this screen, admin can add, delete and update books.
<hr>


![ADMIN ORDERS SCREEN](https://github.com/ismaildemircann/OnlineBookStore/blob/master/images/ADMIN%20ORDERS%20SCREEN.png)

#### ADMIN ORDERS SCREEN

In this screen, admin can see all customer’s orders
<hr>

### 2.3. DESIGN PATTERN DESCRIPTION
Design patterns are an important part of object-oriented programming. We used two types of
design patterns in this project.


* Singleton Pattern

We will explain the singleton desing pattern and why we use it. Singleton Design Pattern is in
the Creational Design Pattern group. Singleton desgin pattern is the design pattern that
guarantees that only one object is created at run time. One of our purposes is to make the logged
in user unique. We created a class for this requirement and let the class managed its own
instance. We accessed instance via getInstance() method via another class. In Singleton Pattern,
an object is created only when we need it. So, we avoided creating global variable. We use this
pattern in Logger class and Logined Customer class in project.

* FactoryMethod Pattern

We used the factory design pattern as the second pattern. The Factory design pattern is a
structure based on class creation. Since the program we wrote has more than one class that is
similar to each other, we used this pattern in order to use the new operator each time when
creating such classes, or to write code as if they were independent from each other. We used
this structure when producing a product with the factories we created or when producing more
than one similar product. We use polymorphism. Product class is not interested in the instance.
Let's think. We are a customer who goes to the restaurant. We want to eat meal but we don't
interested in how the meal cooks. Product class is customer and the instance of product is a
meal. When creating an object, we created a creator object and we created it with the factory.
(BookFactory, MagazineFactory, MusicCdFactory). While accessing the information inside,
we accessed object with virtual FactoryMethod () function by giving the type of our object.

## 3. Authors
* [Gökhan Samet Albayrak](https://github.com/gokhansamet)
* [Yasemin Gerboğa](https://github.com/yasemingerboga)
* [İsmail Demircan](https://github.com/ismaildemircann)
* Elif Esra Eker
* Sina Kuşoğlu
