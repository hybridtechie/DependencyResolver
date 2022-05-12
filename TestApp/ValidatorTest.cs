using FluentValidation;

namespace TestApp;

public class IAmAModel
{
    public IAmAModel(string id, int age)
    {
        Id = id;
        Age = age;
    }
    public string Id { get; set; }
    public int Age { get; set; }
}

public class ValidatorTest : AbstractValidator<IAmAModel>
{
    public ValidatorTest()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Age).GreaterThan(10);

    }
}

