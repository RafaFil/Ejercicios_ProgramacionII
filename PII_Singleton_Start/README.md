# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

Código de ejemplo del patrón [Singleton](https://en.wikipedia.org/wiki/Singleton_pattern)

En este ejemplo la clase `Greeter` es un singleton: solo existe una instancia de esa clase a la cual se accede mediante
una propiedad de clase `Instance` de tipo `Greeter`. No es posible crear instancias de esa clase porque el constructor `Greeter()` es privado. Al acceder por primera vez a la propiedad de clase `Instance` se crea la única instancia de `Greeter` y se guarda en la variable de clase privada `instance`; luego cada vez que se accede a la propiead de clase `Instance` se retorna esa única instancia.

Además la clase `Greeter` implementa un método de instancia `void SayHiToTheWorld()` que es el verdadero propósito de esta
clase.

### Desafío

Usando tipos genéricos implementen una clase con el tipo genérico `Singleton<T>` cuyo tipo parámetro pueda ser cualquier clase; en particular `Greeter`, es decir, el tipo construido quedaría `Singleton<Greeter>`.

Una vez completado el desafío el programa debería lucir así:

```cssharp
static void Main(string[] args)
{
    Singleton<Greeter>.Instance.SayHiToTheWorld();
}
```

> ⚠️ La clase `Greeter` ya es un singleton. El propósito de crear la clase `Singleton<T>` es que cualquier clase, y no sólo `Greeter`, pueda ser un singleton. Al final del desafío les debería quedar en `Greeter` sólo el método
`void SayHiToTheWorld()`.

El tipo genérico `Singleton<T>` crea una instancia de `T`; para que eso sea posible es necesario agregar una restricción
en la declaración del tipo genérico para forzar que T tenga un constuctor sin parámetros; eso se logra con la
declaración `Singleton<T> where T : new()`.

> ⚠️ Los casos de prueba **no** pasan. Pasarán una vez que introduzcan correctamente la clase `Singleton<T>`.
