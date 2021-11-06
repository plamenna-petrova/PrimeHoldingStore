# Solution to the third pre-selection assignment of the Prime Holding .NET Software Engineer internship

## Idea and implementation

The project is divided into two main areas, represented by the folders Models and Store. In the Models folder all the product classes can be found,
starting with the abstract product class, which is inherited from the PerishableProduct, Clothes and Appliances classes. It has fields and properties for
name, brand, price and quantity, but only the first three mentioned are placed in the constructor. As the Product class cannot be instantiated, polymorphism is used
for creating objects from the derivative classes. Here two abstract methods and one virtual method are declared. The aim of the first abstract method is to print the key
product information, according to the characteristics of the classes that override it. Furthermore, the second one calculates the discount if the date and time of purchase
matches the assignment conditions. And the last one prints the base price information - price, multiplied by product quantity. In fact, the level of inheritance might add up
to three, in case of the Food and Beverage classes that inherit the PerishableProduct class. They don't have to override the discount calculation method, since this is done in 
their parent class. In the Store folder the logic is comprised of interfaces and classes that implement them. The Cart class accepts a list of Products and has methods for 
adding a new object to the cart and obtaining all objects, present in the cart. In addition, the calculate payment method encompasses the subtotal, discount and total summation
and prints the calculated results. In the Cashier class a helper method for printing the discount is stored besides the required print receipt method. It checks the product type, 
using reflection and reaches to the discount percentage by subtracting the discount from the product price. Then the information about the discount is printed, if it's available.
Finally in the print receipt method the complete purchase informaton is gathered and printed on the console in consistency with the assignment format.
The examples used are the given one and a class for testing that I have voluntarily added.
