using System;
using System.Collections.Generic;

namespace PizzaDelivery
{
    /// <summary>
    /// Информация о заказе
    /// </summary>
    public class PizzaRequestDto
    {
        
        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Адрес доставки
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Способ оплаты
        /// </summary>
        public PaymentMethod PaymentMethod  { get; set; }
        /// <summary>
        /// Время доставки
        /// </summary>
        public DateTime DeliveryTime { get; set; }
        /// <summary>
        /// Конструктор пиццы
        /// </summary>
        public List<PizzaMaker> Pizza { get; set; }
    }
    
    /// <summary>
    /// Конструктор пиццы
    /// </summary>
    public class PizzaMaker
    {
        /// <summary>
        /// Тип пиццы
        /// </summary>
        public Pizza pizza { get; set; }
        /// <summary>
        /// Грибы?
        /// </summary>
        public bool AddMushrooms {get; set;}
        /// <summary>
        /// Тип теста
        /// </summary>
        public DoughType Dough { get; set; }
        /// <summary>
        /// Размер пиццы
        /// </summary>
        public PizzaSize size { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", pizza, AddMushrooms, Dough, size);
        }

        public PizzaMaker Clone()
        {
            return new PizzaMaker { pizza = pizza, AddMushrooms = AddMushrooms, Dough = Dough, size = size };
        }
    }
    /// <summary>
    /// Размер пиццы
    /// </summary>
    public enum PizzaSize
    {
        small,
        medium,
        large
    }
    /// <summary>
    /// Тип теста
    /// </summary>
    public enum DoughType
    {
        ThinDough,
        TraditionalDough
    }
    /// <summary>
    /// Готовая пицца
    /// </summary>
    public enum Pizza
    {
        Margherita,
        Pepperoni,
        Cheeseburger,
        Vegetables,
        Meat,
        Hawaiian,
        Vegetarian,
        Mexican,
        Marinara,
        ChikenBBQ,
        FourCheese,
        HamNMushrooms,
        FourSeasons,
        Russian
    }
    /// <summary>
    /// Способ оплаты
    /// </summary>
    public enum PaymentMethod
    {
        Cash,
        CreditCardOffline,
        CreditCardOnline
    }
}
