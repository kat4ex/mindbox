# Задание 1 <a name="task1"></a>

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

## Рассуждения
[![Build and test](https://github.com/kat4ex/mindbox/actions/workflows/tests.yml/badge.svg)](https://github.com/kat4ex/mindbox/actions/workflows/tests.yml)  

Круг и треугольник - фигуры, у которых есть свойство **Площадь**.   

Для упрощения процесса интеграции новой фигуры в библиотеку 
был создан интерфейс **IFigure** с единственным свойством **Area**.

Наличие интерфейса позволяет не знать тип фигуры, но быть уверенным, что фигура "умеет" считать свою площадь.

Для проверки прямоугольности треугольника использовалась теорема Пифогора и тот факт, что гипотенуза - самая длинная сторона.


# Задание 2 <a name="task2"></a>

```sql
SELECT Product.name, Category.name
FROM Product
    LEFT OUTER JOIN ProductCategory ON Product.id = ProductCategory.product_id
    LEFT OUTER JOIN Category ON ProductCategory.category_id = Category.id;
```
