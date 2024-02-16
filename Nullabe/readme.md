# Nullable em C#

O tipo `Nullable` em C# é uma estrutura que permite que um valor de tipo de valor (como `int`, `float`, `double`, etc.) possa receber um valor nulo além de seu valor padrão. Isso é útil em situações onde precisamos representar a ausência de um valor em variáveis que normalmente não podem ser nulas.

## Declaração

A declaração de um tipo `Nullable` segue a seguinte sintaxe:

```csharp
Tipo? nomeDaVariavel = valor;
```

Onde:
- `Tipo` é o tipo de valor que você deseja tornar nullable.
- `nomeDaVariavel` é o nome da variável.
- `valor` é o valor que você deseja atribuir à variável, ou `null` se você quiser que a variável seja nula.

## Exemplo de Uso

Aqui está um exemplo simples de como usar `Nullable` em C#:

```csharp
int? idade = null;

if (idade.HasValue)
{
    Console.WriteLine("A idade é: " + idade.Value);
}
else
{
    Console.WriteLine("A idade não foi definida.");
}
```

Neste exemplo, `int?` declara uma variável chamada `idade` que pode conter um valor inteiro ou ser nula. Usamos o método `HasValue` para verificar se a variável `idade` tem um valor atribuído a ela. Se tiver, usamos a propriedade `Value` para obter o valor. Caso contrário, exibimos uma mensagem indicando que a idade não foi definida.

## Considerações

- Os tipos `Nullable` são úteis principalmente em situações onde você precisa distinguir entre um valor que não foi atribuído e um valor que representa a ausência de um valor válido.
- Você pode usar operadores de coalescência nula (`??`) para atribuir um valor padrão a uma variável nullable caso ela seja nula.

```csharp
int? numero = null;
int valorPadrao = numero ?? -1;
```

Neste exemplo, `valorPadrao` seria -1, pois `numero` é nulo.