<<<<<<< Updated upstream
﻿using OperatorForMethods;

<<<<<<< Updated upstream
Discriminant discriminant = new Discriminant();
Console.WriteLine("----------with ref-----------");
double x1 = 0; double x2 = 0;
discriminant.WithRef(3, 22, 3, ref x1, ref x2);
Console.WriteLine("x1= " + x1);
Console.WriteLine("x1= " + x2);
Console.WriteLine("----------without ref(with array)-----------");

double[] arr = new double[2];
double a = 3; double b = 22; double c = 3;
arr = discriminant.WithoutRef(a, b, c);
Console.WriteLine("x1= " + arr[0] + "\nx2= " + arr[1]);



=======
Operation ob1 = new Operation();
Operation ob2 = new Operation();

Operation obS = ob1 - ob2;
Operation obA = ob1 + ob2;
Operation obD = ob1 / ob2;
Operation obM = ob1 * ob2;
Operation obR = ob1 % ob2;

Console.WriteLine(obA.a);
>>>>>>> Stashed changes
=======
﻿
>>>>>>> Stashed changes
