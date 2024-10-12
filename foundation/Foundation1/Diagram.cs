Project 1
---------------------------------------------------------------------
|         Video                     |            Comment            |
|-----------------------------------|-------------------------------|
|  - string: title                  | - string: Commenter            |
|  - string: author                 | - string: message             |
|  - int: length                    |-------------------------------|
|  - List<Comment>: comments        | + string: GetCommenter()      |
|-----------------------------------| + string: GetInput()          |
|+ DisplayInfo(): void              |
|+ int: GetNumberOfComments()       |-------------------------------|
|+ AddComment(Comment:comment): void|
-------------------------------------
Project 2
--------------------------------------------------------------------------------------------
|           Order                   |  Product                   |     Customer            |
+-----------------------------------+----------------------------+-------------------------+
| - customer: Customer              | - string: name             |- string: name           |
| - products: List<Product>         | - int: productId           | - Address: address      |
|-----------------------------------| - int: quantity            |----------------------------
+ float: CalculateTotalCost()       | - int: price               |+ bool: IsUSACustomer(): |
| + string: GeneratePackingLabel()  |-------------------------------------------------------
| + string: GenerateShippingLabel() | + decimal: CalculatePrice()|
+-----------------------------------+-------------------------------+
+----------------------------+
|           Address          |
+----------------------------+
| - string: street           |
| - string: city             |
| - string: Province         |
| - string: country          |
+----------------------------+
| + bool: IsUSAAddress()     |
| + string: GetAddress() |
+----------------------------+