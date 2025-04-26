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
          <div className="grid grid-cols-1 md:grid-cols-4 gap-8">
            {[
              {
                icon: "✔️",
                title: "Прочность",
                text: "Устойчивость к влаге, перепадам температур, царапинам",
              },
              {
                icon: "✔️",
                title: "Экологичность",
                text: "Безопасные материалы без формальдегида и токсинов",
              },
              {
                icon: "✔️",
                title: "Сроки производства",
                text: "Быстрая обработка за счет высокотехнологичного оборудования ",
              },
              {
                icon: "✔️",
                title: "Дизайн",
                text: "Матовые, глянцевые, текстурные решения для любого интерьера  ",
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
              src="/img/mdf.jpg"
              alt="Кухня"
              className="w-full md:w-2/4 rounded-lg md:order-first"
            />
            <div className="md:order-last">
              <h3 className="text-2xl font-semibold mb-2">
                Современные технологии
              </h3>
              <p className="text-xl">
                Holzma и Barberan для окантовки и ламинирования погонажа,
                немецкие станки Weinig и итальянские SCM для комплексной
                обработки изделий. Современная покрасочная камера Cefla для
                безупречного качества отделки. Неограниченные возможности для
                оформления помещений с широкой цветовой гаммой по RAL и NCS, а
                также эксклюзивной брендовой палитрой.
              </p>
            </div>
          </div>
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <img
              src="/img/eco.jpg"
              alt="Столовая зона"
              className="w-full md:w-1/2 rounded-lg md:order-last"
            />
            <div className="md:order-first">
              <h3 className="text-2xl font-semibold mb-2">Экологичность</h3>
              <p className="text-xl">
                Экошпон от корейской компании Decor Valley не содержит галоген,
                фталат, формальдегид, ВТХ, что позволяет получить оценку
                экологичности продукции по определению EN, ASTM и Blaue Angel. В
                составе эмали от компании Renner Italia нет токсичных
                компонентов, что подтверждено сертификатами ISO 9001, Ecolabel,
                Greenguard, СЕ и гарантирует безопасность при использовании
                крашенных фасадов в детской мебели, а также под воздействием
                высоких температур.
              </p>
            </div>
          </div>
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <img
              src="/img/tech.jpg"
              alt="Производство"
              className="w-full md:w-1/2 rounded-lg md:order-first"
            />
            <div className="md:order-last">
              <h3 className="text-2xl font-semibold mb-2">МДФ</h3>
              <p className="text-xl">
                Плиты МДФ позволяют производить элементы любого дизайна:
                мебельные фасады, декоративные рейки и перегородки, стеновые
                панели и напольный плинтус. Они отличаются долговечностью,
                безопасностью и доступной ценой. Материал востребован для
                изготовления мебели в любые пространства в зависимости от их
                назначения и дизайна интерьера. МДФ это: податливость
                механической обработке: фрезеровке, сверлению, шлифовке и
                склейке; устойчивость к механическим ударам; особая прочность за
                счет однородной структуры материала; стойкость к температурным
                перепадам; экологичность.
              </p>
            </div>
          </div>
        </div>
      </section>

      <section className="py-16 bg-[#1D1D1D] text-white">
        <div className="container mx-auto px-6 text-center">
          <h2 className="text-3xl font-bold mb-6">
            Хотите узнать больше о нашей продукции и условиях сотрудничества?
          </h2>
          <p className="text-xl mb-8 max-w-2xl mx-auto">
            Мы ответим на все ваши вопросы и предоставим подробную информацию.
          </p>
          <Link
            to="/contacts"
            className="inline-block bg-[#FBBD39] hover:bg-[#E0A82D] text-[#1D1D1D] font-bold py-3 px-12 rounded-full transition-colors duration-300 text-lg"
          >
            Свяжитесь с нами
          </Link>
        </div>
      </section>
    </div>
  );
}
