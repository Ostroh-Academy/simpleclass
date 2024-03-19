
# Варіант №11

Завдання:

Створити об'єкт класу „конус", який заданий координатами центру основи, координатами вершини та радіусом основи. Визначити за допомогою методу класу, його твірну.


## Використання/Приклади

```javascript
var cone = new Cone(new Point3D(xBaseCenter, yBaseCenter, zBaseCenter),
                new Point3D(xVertex, yVertex, zVertex),
                radius);
                
var generatrix = cone.CalculateGeneratrix();
```

## UML діаграма класів

![uml-diagram.png](img%2Fuml-diagram.png)