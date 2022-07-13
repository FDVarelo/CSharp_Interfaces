# Herdar vs. cumprir contrato

Com o uso da 'Interface', nos podemos fazer algumas coisas que antes mesmo com herança não eram possíveis,
Como por exemplo: 

* Exemplos: Temos uma operação onde utilizados taxa para calcular o total a ser pago, como no exemplo do
ConsoleApp1, no caso da Herança, nos podemos criar essa operação na superclasse, e assim as subclasses podem
herdar essa operação, porem no cado da Interface, nos também criamos essa operação na interface, porém ela funciona
de maneira diferente, quem for uma classe concreta quem implemente a interface em questão, essa classe tem que ter
essa operação implementada na classe.

* Outro exemplo é do desse ConsoleApp3, onde caso eu precise implementar Shape como uma interface, porém também quiser
definir uma estrutura comum reutilizável para todas as figuras, isso é util pois, caso queira criar uma classe concreta
que queira utilizar a classe Area() do IShape.cs, porém que não possuem cor, sendo que, caso fosse utilizar da mesma forma
so que com herança, teria o problema de que toda classe concreta de Area() teria que necessariamente ter de informar uma cor.