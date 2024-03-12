
using Generics;

//Intlist datas = new Intlist();
//datas.Add(1);
//datas.Add(2);
//datas.Add(3);

//datas.Add(4);

//datas.Add(5);
//int[]result=datas.GetAll();
//foreach(int item  in result)
//{
//    Console.WriteLine(item);
//}


//StringList stringList = new StringList();
//stringList.Add("salam");
//stringList.Add("sagol");
//var result2=stringList.GetAll();
//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<int> datas=new DataList<int>();

//DataList<string>dataList=new DataList<string>();

//DataList<bool> datalist1=new DataList<bool>();
//datas.Add(100);
//datas.Add(200);
//datas.Add(300);

//var result = datas.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<string> datalist=new DataList<string>();

//datalist.Add("sallam");
//datalist.Add("sagol");
//var result2 = datalist.GetAll();
//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}

//DataList<bool>dataList1=new DataList<bool>();
//dataList1.Add(true);
//dataList1.Add(false);
//var result3 = dataList1.GetAll();
//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//}
//DataList<Book> books=new DataList<Book>();
//books.Add(new Book { Id=1,Name="test1"});
//books.Add(new Book { Id=2,Name="test2"});
//books.Add(new Book { Id=3,Name="test3"});
//var result=books.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}

DataList<int> dataList = new DataList<int>();
dataList.Add(10);
dataList.Add(20);
dataList.Add(25);

bool result=dataList.Delete(20);

if (result)
{
    Console.WriteLine("20 successfuly removed");
}
else
{
    Console.WriteLine("20 not found");
}
int[] alldata=dataList.GetAll();
Console.WriteLine("All Data:");
foreach (int data in alldata)
{
    Console.WriteLine(data);
}
