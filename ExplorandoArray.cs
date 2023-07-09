
    //Qual a diferença prática entre string e String?
    string[] personagens;//Declarando a array sem o tamanho
    string[] stringArr = new string[3] { "value1", "value2", "value3" };
    String[] programa = new String[3] { "Catfish", "South Park", "Bob Esponja" }; //Já incluindo os valores da array

    //Atribuindo valor à uma index
    personagens = new string[3];
personagens[1] = "Pica-Pau";

//Instanciando na hora
string[] animais = new string[10];
    //Instanciando depois
    string[] insetos;
    insetos= new string[10];



// Atribuindo valores e imprimindo
Console.WriteLine(personagens[1]);
Console.WriteLine(stringArr[1]);
Console.WriteLine(programa[0]);
Console.ReadLine();
