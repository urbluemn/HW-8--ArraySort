//Напишите обобщенный класс, который может хранить в массиве объекты любого типа. Кроме того, данный класс должен иметь методы для добавления данных в массив,
//удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.
//Отнаследуйте от этого класса экземпляр класса, принимающий в качестве параметра int. Реализуйте операторы сложения, сравнения, а так же индексатор.

//class Collection<T>

//    // добавление данных
//    public void Add
//    // удаление данных - удаляем первое вхождение элемента при его наличии
//    public void Remove
//    public ??? GetItem
//    public int Count

//class Collection<int>
//+ == != this

using ArraysSort;

Collection<int> array1 = new Collection<int>();
Collection<int> array2 = new Collection<int>();

array1.Add(5);
array1.Add(2);
array1.Add(3);
array1.Add(7);
array1.Add(9);

array2.Add(34);
array2.Add(3);
array2.Add(6);
array2.Add(13);
array2.Add(25);

Console.WriteLine(array1 == array2);

Console.WriteLine(array1.Count);
array1.Remove(2);
Console.WriteLine(array1.GetItem(3));