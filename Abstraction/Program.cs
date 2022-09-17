using Absrtact_Drawing;

Drawing ob = new Portrait_Painter();

ob.environment = "Streets";
ob.paper = "Paper";

ob.Draw();

Drawing ob1 = new Sea_Painter();

ob1.environment = "Front of sea";
ob1.paper = "Parchment";

ob1.Draw();


Drawing ob2 = new Nature_Painter();

ob2.environment = "Forest";
ob2.paper = "Canvas";

ob2.Draw();
