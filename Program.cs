	
string[] arrayNew = {"666", "123", "3445", "Вася", "245345455", "54545"};

var listArray = new List<string>();

for(int i = 0; i <  arrayNew.Length; i++){
    if(arrayNew[i].Length <= 3) listArray.Add(arrayNew[i]);   
}