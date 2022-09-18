using _01_InterfaceAndInterface;

Result result = new Result();
//es dzevov classy haytarareluc result i hamar baci Objecti methodneric voch mi ban chi berum`
//Equals,GetHash,GetHashCode,ToStirng
//vorovhetev chi haskanum vor methody kanchi,2-n el nuyn anunov en ,dra hamar hstakecum piti anenq
//ham el iranq private en,chi el karana beri

IInterface1 result1 = new Result();
result1.Method();

//es dzevov karoxacanq arden kanchel Method1
//vorovhetev senc arden asum enq vor IInterface1-i method enq stexcum,uxxaki Result-i constructorov(interface constructor unenal cher karox)
//u arden haskanum e te menq inch enq uzum kanchel

IInterface2 result2 = new Result();
result2.Method();
//analog dzevov ashxatum e naev IInterface2-i hamar
//senc karum enq anenq,vorovhetev interface-i andamnery public en by default


/*When using explicit interface implementations, the functions are not public on the class. 
  Therefore in order to access these functions, you have to first cast the object to the interface type,
  or assign it to a variable declared of the interface type.*/

//aysinqn tipov haytararelu poxaren karanq naev cast anenq

var result3 = new Result();
((IInterface1)result3).Method();
//IInterface1-i implementacian ktpi

((IInterface2)result3).Method();
//IInterface2-i implementacian ktpi


/*what if Method() is declared public in both the interfaces and the Dual class? – 

Methods/properties on an interface are always public - that is the entire point of an interface. But when you use an
explicit interface implementation, the function will always be private on the class. That is why you need the technique
to cast the class to the specific interface that you need. When you do implement two interfaces that define methods with
identical signature, you cannot avoid this. */



