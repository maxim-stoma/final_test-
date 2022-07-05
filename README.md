# Итоговая проверочная работа

## Необходимые задачи для выполнения

1. Создать репозиторий на [Github](https://github.com/).
2. Нарисовать блок-схему алгоритма решения поставленной задачи.
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе на этим небольшим проектом.

## Условие задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнния алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
* [ "hello", "2", "world", ":-)" ] -> ["2", ":-)"];
* ["1234", "1567", "-2", "computer science"] -> ["-2"];
* ["Russia", "Denmark", "Kazan"] -> [ ]

## Написание программы

Алгоритм решения опирается на использование методов. Были написаны три метода:
* метод *SetArray* - задаёт массив, позволяя ввести значения элементов с клавиатуры;
* метод *PrintArray* - вывод массива на экран;
* метод *FindThreeSymbolElements* - определяет элементы массива, размер которых не превышает 3 символа.

Далее создаётся определяется новый массив, который заполняется с использованием метода *SetArray* и выводится на экран с помощью метода *PrintArray*.

В полученном массиве методом *FindThreeSymbolElements* определяются элементы с размером меньше или равным 3 и выводятся на экран методом *PrintArray*.

## Составление блок-схемы

Составленная блок-схема алгоритма решения имеет несколько крупных блоков:
1. Определяются первые переменные, которые будут хранить информацию о номере элемента массива (переменные index и position);
2. Производится определение размера исходного массива (переменная arraySize) и заполнение его элементами (originArray[index]);
3. Выводится исходный заполненный массив;
4. Поиск элементов исходного массива с размерностью меньшей или равной 3 и последовательная запись их в итоговый массив;
5. Вывод итогового массива.