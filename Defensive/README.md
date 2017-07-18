# Introduction
Module for me to learn more about defensive coding in C#.

Touches on subjects such as writing clean and maintanable code
to testing said code using manual and automatic testing.

## KeyWords

- **Clear Purpose**

A method should have clear purpose. 
Preferably it should do one thing and one thing only.
That one functionality should be performed to the
best of its ability.


- **Good Name**

A method should have a good, descriptive name to
make it more readable by other developers and other
people trying to understand it.

- Focused Code

As mentioned in **Clear Purpose** a method should 
be focused on solving one particular problem well
rather than doing multiple things *decent*.

This being said a method could hold multiple methods 
and function as a sort of intermediary / controller,
like the `ProcessOrder` method in **OrderWin**'s 
code behind.

- Short Length

A method should be as short as possible, ie. refactored
to the best of the developer's ability. 

It should be short and sweet.

- Automated Code Test


- Predictable Result

A method should be predictable in the sense that it should
use proper validation for its purposes and output 
*good* return values.

# Defending Your Methods

## Part 2

### Guarding

Guarding is the concept of guarding your code from 
unpredictable input. One way of doing this is by 
using *quick* or *fast* guarding, which includes
validating variables or parameters by rules set by
your method. 

In the **Customer** we are using this to quickly
fend off incorrect input from the **PedometerWin**'s 
textboxes by throwing `ArgumentExceptions` and 
giving a stacktrace that is easy for a developer to 
understand.

### Design By Contract

- **What does the method expect?**

This defines the acceptable, and unacceptable input.

- **What does the method guarantee?**

That defines the promised return value, expected errors
and/or exceptions.

- **What does the method maintain?**

Defines any properties used or set by the method.


### Asserts, Errors and Exceptions

#### How do we handle user entered data?

- **Use an appropriate Control**

Ensure you are using a correct user control for the target data that you expect the user to input.

- **Use built in data validation**

When a controler uses databinding, the controller usually has some form of built-in validation. Use it.
Most also display a message to the user when something goes wrong.

- **Write a validation model**

Write a validation method to help display errors and messages, much like the 
`OperationsResults` class.
- **Validate with guard clauses**

Validate through using Guard clauses, which we have used throughout the course. 
They also may make it easier to find the source of an error whilst debugging.

- **Proceed with good default value**

Simply proceed with a good default value. Imagine that a user is tasked with deciding on 
a color and font-style for a textbox in the application. One way of guaranteeing *good* user entry
would be to have a default value in those boxes, so the user always will have something before moving on.


#### What if there is missing or invalid data?


- **Validate incoming data**

Validate all the data that might be incoming to a database or a system. 

- **Proceed without the value**

Consider this: if the validation of some data hasn't been passed successfully when performing 
a time-critical task, it might be more beneficial to proceed without it - if it's not critical.
Imagine having to print a report or receipt. Should we stop the entire process just becase a user
might be missing a first name or similar?

- **Proceed with a good default value**

Consider the above example again. Wouldn't this be a good opportunity to have a *good default value* in place?
Wouldn't it be better if the model we are performing an action on had a default value that it could fall back
on? 

- **Display a message to the user**

However in some cases you might be dealing with data that simply is required for the system to fully function.
In that case display an error message to the user so that he or she can make the appropriate changes.
Preferably use an operation result or an exception message to clearly state what the error may be and what
changes might have to be done.

#### What if the issue is a flow of control problem?

Such as a missing switch case or if-clause.

- **Proceed with a default operation**

Is it possible for us to continue along the system's flow, even with some loss of data? 
One way of doing this is by setting up a default method or set of operations that we should move along
if the field's might be of incorrect value. 

- **Ignore the issue**

Consider to ignore the issue entirely. Say a switch statement has been setup to either send a receipt either
on email or text, but the value was null or invalid. It may be enough to ignore the issue and continue, but ensure 
the issue may not cause any future problems and keep the issue in mind when extending the solution.

- **Log it and display a message to the User**

If you do find yourself in a position where you need to display an error message to the user, make sure 
it's clear and precise, so that the user has a clear idea of the problem and how to solve it.

#### System Issues

These issues cover the system issues that may occur during runtime, such as missing files that are referenced,
disk issues or more commonly, database connectivity issues.

- **Try again**

In some of these cases we can at least have a few checks before we tell the user that something has gone wrong.
In the case of a database connectivity issue you might want to test the connection a few times(3) before
you can safely assume an error might have occurred.

- **Proceed with an alternate operation**

In some cases it might be appropriate to use a default operation to fall back on in case the primary operation fails.
If you don't have access to the internet you might consider falling back on a local version of the database
that you might have as a snapshot on your device. This ensures some of the functionality is persistent and
may allow the user to perform some of her actions. Then when the device has access to the internet again, 
an automatic upload may occur to ensure that the database is up to date with the entered information and 
that the local database is up to date.

- **Ignore the issue**

Depending on the issue, it could be ignored. For example say the system displays the weather (external
tool) in the corner of the application. 
In case the weather system is down, you may be able to simply ignore it, because it doesn't have any 
impact on the system.

- **Log it and display a message to the user**

In some cases you may need to abort the operation and display an error to the user.


### Anticipated Issues and Expectations

How can we go about solving the above problems?

- **Use restrictive controls and binding**
- **Use validation methods**
- **Use good defaults**
- **Return Operation Result**
- **Throw Exceptions**
- **Notify the user only when necessary**