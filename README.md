# Code Convention

## C-Sharp
Reference: https://google.github.io/styleguide/csharp-style.html

### Naming convention
- Private field should start witn underscore ("_") prefix, using camel-case naming. Ex: `_studentName`.
- Naming local variable as camel-case, ex: `studentname`
- Naming interface, class, struct, enum, delegate, event, namespace using Pascal-case. Ex: `StudentClass`
- Naming method using Pascal case, `CalculateStudentAveragePoint()`, start with an verb.
- Naming property as a noun/adjective using Pascal case.
- Naming parameter/argument using camel-case.
- Interface should have prefix `I`, ex: `IStudent`
- Type parameters should have prefix `T`. Ex: `TKey`, `TValue`

### Code formating
- Braces is required after `if`, `elseif`, `else`, `for`, `do..while`, `while..do`