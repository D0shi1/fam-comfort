import React from "react";
import { Link } from "react-router-dom";
import product1 from "../img/test2.jpg";
import { HeroSlider } from "../components/MainPage/HeroSlider";

export function HomePage() {
  const featuredProducts = [
    { id: 1, name: "Фасад 1", price: "от .....", image: product1 },
    { id: 2, name: "Фасад 2", price: "от .....", image: product1 },
    { id: 3, name: "Фасад 3", price: "от .....", image: product1 },
  ];

  return (
    <div className="min-h-screen bg-gray-50">
      <section className="relative bg-[#1D1D1D] text-white">
        <HeroSlider />
      </section>

      <section className="py-16 bg-white">
        <div className="container mx-auto px-6">
          <h2 className="text-3xl font-bold text-center mb-12">
            Почему выбирают нас
          </h2>
          <div className="grid grid-cols-1 md:grid-cols-3 gap-8">
            {[
              {
                icon: "🏭",
                title: "Собственное производство",
                text: "Изготавливаем фасады без посредников",
              },
              {
                icon: "🤝",
                title: "Работа без посредников",
                text: "Вы будете работать напрямую с фабрикой без посредников",
              },
              {
                icon: "🖌️",
                title: "Ваши мебельные идеи в формате 3D",
                text: "Предоставляем прорисованные модели мебели в программе 3ds Max.",
              },
            ].map((item, index) => (
              <div
                key={index}
                className="bg-gray-50 p-6 rounded-xl hover:shadow-lg transition-shadow duration-300"
              >
                <div className="text-4xl mb-4">{item.icon}</div>
                <h3 className="text-xl font-semibold mb-2">{item.title}</h3>
                <p className="text-gray-600">{item.text}</p>
              </div>
            ))}
          </div>
        </div>
      </section>

      <section className="py-16 bg-gray-50">
        <div className="container mx-auto px-6">
          <div className="flex justify-between items-center mb-12">
            <h2 className="text-3xl font-bold">Популярные фасады</h2>
            <Link to="/catalog" className="text-[#FBBD39] hover:underline">
              Смотреть все →
            </Link>
          </div>

          <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-8">
            {featuredProducts.map((product) => (
              <div
                key={product.id}
                className="bg-white rounded-xl overflow-hidden shadow-md hover:shadow-xl transition-shadow duration-300"
              >
                <img
                  src={product.image}
                  alt={product.name}
                  className="w-full h-64 object-cover"
                />
                <div className="p-6">
                  <h3 className="text-xl font-semibold mb-2">{product.name}</h3>
                  <p className="text-[#FBBD39] font-bold mb-4">
                    {product.price}
                  </p>
                  <Link
                    to={`/product/${product.id}`}
                    className="inline-block border border-[#1D1D1D] hover:bg-[#1D1D1D] hover:text-white py-2 px-6 rounded-full transition-colors duration-300"
                  >
                    Подробнее
                  </Link>
                </div>
              </div>
            ))}
          </div>
        </div>
      </section>

      <section className="py-8 bg-white">
        <div className="container mx-auto px-6 space-y-8">
          <h2 className="text-3xl font-bold text-center mb-10">О нас</h2>
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <img
              src="/img/slide3.jpg"
              alt="Кухня"
              className="w-full md:w-2/4 rounded-lg md:order-first"
            />
            <div className="md:order-last">
              <h3 className="text-2xl font-semibold mb-2">
                Опыт и ассортимент
              </h3>
              <p className="text-xl">
                Вот уже более 20 лет ООО «ОМЦ-Профиль» работает в мебельной
                индустрии и создаёт широкий ассортимент мебельных фасадов и
                декоративных элементов: багетов, балюстрад, пилястр, плинтусов.
                Наши изделия широко применяются для производства кухонной
                мебели, но с таким же успехом могут применятся для изготовления
                гардеробов, шкафов и тумб для любых жилых помещений.
              </p>
            </div>
          </div>
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <div className="md:order-first">
              <h3 className="text-2xl font-semibold mb-2">
                Оформление интерьера
              </h3>
              <p className="text-xl">
                Мы также выпускаем изделия для оформления интерьера:
                декоративную рейку, реечные панели, плинтуса, консоли, багеты,
                наличники. Начиная с 2015 года, компания производит корпусную
                мебель для гостиной и спальни. Мы с уверенностью заявляем, что
                наша фабрика - один из лидеров в РБ по производству профиля из
                МДФ.
              </p>
            </div>
            <img
              src="/img/slide3.jpg"
              alt="Столовая зона"
              className="w-full md:w-1/2 rounded-lg md:order-last"
            />
          </div>
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <img
              src="/img/slide3.jpg"
              alt="Производство"
              className="w-full md:w-1/2 rounded-lg md:order-first"
            />
            <div className="md:order-last">
              <h3 className="text-2xl font-semibold mb-2">
                Производственные мощности
              </h3>
              <p className="text-xl">
                Наши производственные цеха оборудованы современным
                высокотехнологичным оборудованием лучших немецких и итальянских
                брендов. Для облицовывания мы используем только немецкие клея и
                облицовочные материалы немецкого и японского производства. Что
                позволяет добиться высокого качества выпускаемой продукции. И
                гарантировать покупателю отличные эксплуатационные
                характеристики нашей продукции.
              </p>
            </div>
          </div>
        </div>
      </section>

      <section className="py-16 bg-[#1D1D1D] text-white">
        <div className="container mx-auto px-6 text-center">
          <h2 className="text-3xl font-bold mb-6">
            Готовы создать кухню вашей мечты?
          </h2>
          <p className="text-xl mb-8 max-w-2xl mx-auto">
            Оставьте заявку и получите бесплатный дизайн-проект и расчет
            стоимости
          </p>
          <Link
            to="/contact"
            className="inline-block bg-[#FBBD39] hover:bg-[#E0A82D] text-[#1D1D1D] font-bold py-3 px-12 rounded-full transition-colors duration-300 text-lg"
          >
            Оставить заявку
          </Link>
        </div>
      </section>
    </div>
  );
}
