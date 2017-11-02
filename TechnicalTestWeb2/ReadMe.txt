This solution is a simple web application that allows users to have a 
set of shipments associated with their customer account.

Please make a copy of this git repo in your repo called TechnicalTestWeb2
Please make updates in this file and to the code and push when complete( or end of class) 

Item 1: Setup..
There is script file located in the "SQL Script", directory.
Create a database and using SQL Management Console exedcute the script to populate the data.
Note: You will have to update the Web.config to reference your DB name/credentials

ANSWER 1: Ran script to create database and changed connection string
<connectionStrings>
    <add name="DataModel" connectionString="Data Source=LAPTOP-S6VCNNS6;Initial Catalog=InClass;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
  </connectionStrings>
-------------------------------------------------------------------------------------------------------

Item 2: 
There is one compilation error in the project fix it.

Please Answer:
What was it?  How did you fix?
ANSWER 2: changed to ServiceType in Shipment model
-------------------------------------------------------------------------------------------------------
Item 3:
The Shipments link in the menu bar of the app is not working, 
it should like to the index page of the ShipmentsController 

Please Answer:
What was it?  How did you fix?
ANSWER 3: changed in _Layout.cshtml :  <li>@Html.ActionLink("Shipments", "Index", "Shipments")</li>
-------------------------------------------------------------------------------------------------------
Item 4:
Make the name label for the Customer on the shipment object say "Customer Name" in all places

Please Answer:
What was required to fix?
ANSWER 4: added  [Display(Name = "Customer Name")] to Shipment Model
		  and removed "Customer ID" from shipment/edit view to take default name
------------------------------------------------------------------------------------------------------
Item 5:
There is a bug in the code.
The estimated ship date must be at least 24 hours after the Date Ordered.  Fix

Please Answer:
What was wrong and what was required to fix?

ANSWER 5:
int result = DateTime.Compare(estShipDate, orderPlacedDate.AddHours(24) );

            if (result < 0)
            {
                return new ValidationResult("The estimated ship date must be at least 24 hours after the Date Ordered");
            }
------------------------------------------------------------------------------------------------------

Item 6:
When Editing customer Nitin, the province appear as Quebec.  Not Ontario - the default for create.

Explain why it was not Ontario or NS?
ANSWER 6:
It was not Ontario because we are not initializing a new customer object.
It was not NS because in @Html.DropDownListFor(model => model.province, new SelectList(Model.provinces, "Value", "Text"),new { @class = "form-control" })
model.province value from database("NS") is not found in SelectList of provinces and hence it defaults back to show Quebec without selection(being first item in list)                

------------------------------------------------------------------------------------------------------
Item 7:
Add a button to the right of the customer dropdown to open the add a new customer.
Hint: you can use @Html.ActionLink ( does not have to be a button)

ANSWER 7: add @Html.ActionLink("Add New Customer","Create","Customers") in shipments edit view page as follows:

div class="form-group">
            @Html.LabelFor(model => model.CustomerID, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("CustomerID", null, htmlAttributes: new { @class = "form-control" })
                @Html.ValidationMessageFor(model => model.CustomerID, "", new { @class = "text-danger" })
                @Html.ActionLink("Add New Customer","Create","Customers")
            </div>

-----------------------------------------------------------------------------------------------------
Item 8:
Convert Text dates to date picker
ANSWER 8: Added the following in shipment model for both EstShippedDate and DateOrderPlaced 
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

