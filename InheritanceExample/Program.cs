

//Inheritance

using InheritanceExample;
//coder is inheriting from person = coder is a person now
var erik = new Coder();

erik.Name = "Erik";
erik.Age = 23;
erik.ProgrammingLanguage = "C#";
erik.Greet();
erik.Code();

var bob = new Person();

bob.Name = "Bob";
bob.Age = 43;
bob.Greet();

var bill = new Sport();
bill.Name = "Bill";
bill.Sporting = "Ball game";
bill.PlayGame();

//Constructors are the only classes inherited, not the base or parent class