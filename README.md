# Знакомство с языками программирования - ДЗ № 3

## Содержание ДЗ

* **`Program.cs`** - главное меню домашней работы. Для его работоспособности, **в одной дерриктории с ним должны располагаться все файлы данного репозитория** (за исключением README.md).

* **`Task19.cs`** - Задача № 19 - *на входе пятизначное натуральное число, а на выходе информация является ли оно палиндромом.* Организован контроль ввода. Допустимо использование **пятизначных натуральных** чисел, соответствующих типу Integer. Пробелы по обе стороны числа игнорируются.

* **`Task19Hard.cs`** - Задача № 19 HARD - *на входе натуральное число (или ноль), а на выходе информация является ли оно палиндромом.* Организован контроль ввода. Допустимо использование **натуральных** чисел (или **ноль**), соответствующих типу Integer. Пробелы по обе стороны числа игнорируются.

* **`Task21.cs`** - Задача № 21 - *на входе координаты двух точек в трехмерном пространстве, на выходе расстояние между ними.* Организован контроль ввода. Допустимо использование **целых** чисел, соответствующих типу Double. Осуществляется контроль кол-ва координат. Пробелы по обе стороны координат игнорируются.

* **`Task21Hard.cs`** - Задача № 21 HARD - *на входе координаты двух точек в N-мерном пространстве, на выходе расстояние между ними.* Организован контроль ввода. В качестве числа N допустимо использование **натуральных чисел**, соответствующих типу Integer. В качестве координат допустимо использование **целых** чисел, соответствующих типу Double. Осуществляется контроль кол-ва координат. Пробелы по обе стороны координат игнорируются.

* **`Task23.cs`** - Задача № 23 - *на входе натуральное число N, а на выходе список кубов чисел от 1 до N включительно.* Организован контроль ввода, допустимо использование **натуральных** чисел, соответствующих типу Integer. Пробелы по обе стороны числа игнорируются.

## P.S.

* В задачах 21 и 21 Hard, несмотря на используемый тип Double для координат, программа допускает к использованию только целые числа. Связано с тем, что в примерах задания присутствуют только целые числа, да и они больше приятны глазу при вводе. Однако, если в коде в качестве разделителя между координат установить не запятую, а любой другой символ (например ;), то к вводу станут доступны и дробные числа. Дополнительно пресекается возможность предоставляемая double.Parse(), скормить ввод пробелов внутрь числа (например "1 1" = "11"). В свою очередь int.Parse() такое себе не позволяет и это правильно.

* Связи между главным меню и задачами реализованы через публичные классы и методы.