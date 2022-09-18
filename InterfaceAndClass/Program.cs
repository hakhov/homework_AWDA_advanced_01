using InterfaceAndClass;

Result result = new Result();
result.Method();
//es depqum kberi henc result classi meji methody,cnox classi methody pakum a inqy
//menak henc classiny karanq kanchenq,voch cnoxiny,voch el interfaceneriny es tarberakov chenq karox

//isk ete pakenq Resulti meji ira Method(),arden ktpi ClassA-iny,vorovhetev menak inqy hasaneli klini

IInterface1 result1 = new Result();
result1.Method();
//kberi IInterface1-i implementacian


IInterface2 result2 = new Result();
result2.Method();
//kberi IInterface2-i implementacian

((ClassA)result).Method();
//kam el senc cast anelov ktpi henc ira methody

