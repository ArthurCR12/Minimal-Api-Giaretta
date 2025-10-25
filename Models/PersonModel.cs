namespace Person.Models;

public class PersonModel
{
    public PersonModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    // Esse init permite que a propriedade seja definida apenas durante a inicialização do objeto
    public Guid Id { get; init; }
    public string Name { get; private set; }
}
