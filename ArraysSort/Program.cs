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

Collection<int> collection = new Collection<int>();

collection.Add(5);
collection.Add(2);
collection.Add(3);
collection.Add(7);
collection.Add(9);
Console.WriteLine(collection.Count);
collection.Remove(2);
Console.WriteLine(collection.GetItem(3));