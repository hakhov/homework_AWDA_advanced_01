using Explisit_Implisit;

Year year = new Year(4);
year.Print();
Day day = (Day)year;
day.Print();
Month month = (Month)year;
month.Print();

Day day2 = day + (Day)month;
day2.Print();
Year year2 = year + (Year)day2;
year2.Print();
Month month2 = (Month)year2 - month;
month2.Print();

Day day3 = (Day)year2 + day + day;
day3.Print();