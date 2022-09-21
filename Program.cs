	
string[] arrayNew = {"666", "123", "3445", "Вас", "245345455", "54545"};

var listArray = new List<string>();

for(int i = 0; i <  arrayNew.Length; i++){
    if(arrayNew[i].Length <= 3){
        listArray.Add(arrayNew[i]);   
    }  
      
}


if(listArray.Count > 0){

    string[] array = new string[listArray.Count];

    listArray.CopyTo(array);

    Console.WriteLine("Строки в массиве длинной меньше или равно 3:");

    for(int j = 0; j <  array.Length; j++){

        Console.WriteLine(array[j]); 

    } 

}
else{
    Console.Write("Нет строк с количеством меньше или равно 3-м");
}