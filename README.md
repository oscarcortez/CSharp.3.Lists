# CSharp.3.Lists

una lista se declara de esta manera: 
```csharp
var names = new List<string> { "<name>", "Ana", "Felipe" };
```

Para iterarlo se puede hacer con for, foreach, y foreach como methodo propio de list
```csharp
names.ForEach(name => {
    Console.WriteLine($"con foreach method: {name}");
});
```

```csharp
foreach(var al in algo)
{
    Console.WriteLine(al);
}
```

Tb tiene la funcion de agregar uno por uno
```csharp
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
```

un List internamente maneja un generic y acepta todo tipo de variables incluyendo clases y structs
