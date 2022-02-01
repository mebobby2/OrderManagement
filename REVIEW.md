Serko Code Review Interview
[GitHub - mebobby2/OrderManagement: Order Management Solution for Code Review Session](https://github.com/mebobby2/OrderManagement)

## Correctness
* Hard to tell without unit tests
* error handling
	* e.g. not checking for valid inputs when entering quantities of shapes
* Thorough testing and validation of cases is not part of the code review - a QA does this
* Order numbers are not generated

## Design
* Overall design
	* need a separation of product catalog so can decouple prices from the catalog to those of the order
		* => when prices of products change, it doesn’t affect existing orders
* structure of code could be better. Can put into subdomains/folders
	* reports (CuttingListReport, InvoiceReport, PaintingReport)
	* orders (Order, Shape)
	* root (Program)
* Shape class
	* Not much behaviour in this class. Anemic class. Introducing this class hierarchy makes the design rigid.
	* responsibility of this class seems to capture the customer’s orders. So instead, we could change this to a Order class.
	* Then we also add members of type Customer and ProductList into the order class
	* methods like Total costs can be implemented as Linq on the ProductList class
	* The Order class will also handle the business logic of Surchages
	* Then it also handle validations such as DueDate is not in the past
	* Order then acts as the root aggregate entity
	* function AdditionalChargeTotal is used
* Square, Triangle, and Circle can be DRYed
	* the logic to calculate Total (using red, blue, and yellow) are the same
	* these classes can probably be removed and just maintain the products as a Dictionary of objects since there are no behaviour
* The order object should be renamed to Report have the Order object injected into it

## Feedback from the Interview
I passed with flying colours - I know what to look for in a codebase regardless of programming language.

Some points he pointed out:
- in the correctness section, if we introduce unit tests, then the codebase needs to be re-structured to use dependency injection - to allow for unit testing but also promote loosely coupled designs
- my product interface, even though it was an interface, it's still inheritance (which I kind of disagreed because it's there not as a superclass but for type safety).
	- he did point out a maintenance flaw, that if I have lots of these shapes, I would have to create lots of subclasses and this will make codebase explode. We both agreed a better way is to store them as hashes or dictionaries.
