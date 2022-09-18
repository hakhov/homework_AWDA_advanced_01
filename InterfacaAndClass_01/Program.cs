using InterfaceAndClass_01;

Result result = new Result();
result.Method();
//henc ira methody ktpi
//child-i constructory kancheluc meka galu e base-inn el mtni


((ClassA)result).Method();
//senc dzevov el Result classiny tpec,voch te classA-iny
//nenc vor cast dnenq chdnenq nuynn e


//Result result1 = new ClassA();
//ystex chi toxnum ClassA-i constructorov stexcel

IInterface1 result1 = new Result();
result1.Method();