import React from "react";

export function AboutPage() {
  return (
    <div className="min-h-screen bg-gray-50">
      <section className="py-10 bg-white">
        <div className="container mx-auto px-6">
          <h1 className="text-4xl font-bold text-center mb-4 pb-10">
            О компании
          </h1>
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <div className="md:w-1/2 text-center md:text-left mb-6 md:mb-0">
              <p className="text-lg text-gray-700">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer
                nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed
                nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis
                ipsum.Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                Integer nec odio. Praesent libero. Sed cursus ante dapibus diam.
                Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis
                sagittis ipsum.Lorem ipsum dolor sit amet, consectetur
                adipiscing elit. Integer nec odio. Praesent libero. Sed cursus
                ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum
                imperdiet. Duis sagittis ipsum.Lorem ipsum dolor sit amet,
                consectetur adipiscing elit. Integer nec odio. Praesent libero.
                Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh
                elementum imperdiet. Duis sagittis ipsum.Lorem ipsum dolor sit
                amet, consectetur adipiscing elit. Integer nec odio. Praesent
                libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem
                at nibh elementum imperdiet. Duis sagittis ipsum.Lorem ipsum
                dolor sit amet, consectetur adipiscing elit. Integer nec odio.
                Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla
                quis sem at nibh elementum imperdiet. Duis sagittis ipsum.
              </p>
            </div>

            <div className="md:w-1/2 flex justify-center md:justify-end">
              <img
                src="src/img/logo.jpg"
                alt="Логотип компании"
                className="w-480 h-auto"
              />
            </div>
          </div>

          <div className="container mx-auto p-6">
            <div className="w-full h-1/4 md:h-[500px] lg:h-[600px]">
              <iframe
                className="w-full h-full rounded-lg shadow-md"
                src="https://www.youtube.com/embed/PofQaXypH4E"
                title="YouTube video player"
                frameBorder="0"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                allowFullScreen
              ></iframe>
            </div>
          </div>
        </div>
      </section>

      <section className="py-16 bg-gray-50">
        <div className="container mx-auto px-6 text-center">
          <h2 className="text-3xl font-bold mb-12">Ассортимент</h2>

          <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-6">
            <div>
              <img
                src="/src/img/test2.jpg"
                alt="Профиль погонажный"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Профиль погонажный</p>
            </div>

            <div>
              <img
                src="/src/img/test2.jpg"
                alt="Фасады"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Фасады</p>
            </div>

            <div>
              <img
                src="/src/img/test2.jpg"
                alt="Декор"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Декор</p>
            </div>

            <div>
              <img
                src="/src/img/test2.jpg"
                alt="Мебель"
                className="w-full h-48 object-cover rounded-lg shadow-md cursor-pointer hover:scale-105 transition-transform duration-300"
              />
              <p className="text-lg font-medium mt-4">Мебель</p>
            </div>
          </div>
        </div>
      </section>

      <section className="py-16 bg-white">
        <div className="container mx-auto px-6 space-y-12">
          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left">
              <h3 className="text-xl font-bold mb-4">Профиль погонажный</h3>
              <p className="text-lg text-gray-700">
                Это один из ключевых элементов нашего ассортимента.
                Изготавливаемый из высококачественного МДФ, произведенного в
                Беларуси, России и Польше, он выделяется исключительной
                прочностью и эстетикой. Широкий выбор форм и дизайнов делает
                этот профиль незаменимым материалом для создания неповторимой
                мебели, который подойдет как для классических, так и современных
                интерьеров.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/profil.jpg"
                alt="Профиль погонажный"
                className="w-full h-64 object-cover rounded-lg shadow-md"
              />
            </div>
          </div>

          <div className="flex flex-col md:flex-row-reverse items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left pl-5">
              <h3 className="text-xl font-bold mb-4">
                Фасады рамочные и лакированные
              </h3>
              <p className="text-lg text-gray-700">
                Наша гордость, представленная в более чем 30 коллекциях, каждая
                из которых создаёт атмосферу утончённости и стиля. Эти фасады не
                только украшают мебель, но и обеспечивают её долговечность и
                функциональность. Благодаря разнообразию цветов, текстур и форм,
                фасады идеально адаптируются к индивидуальному стилю и дизайну
                помещения.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/facades.jpg"
                alt="Фасады"
                className="w-full h-64 object-cover rounded-lg shadow-md"
              />
            </div>
          </div>

          <div className="flex flex-col md:flex-row items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left">
              <h3 className="text-xl font-bold mb-4">Декоративные элементы</h3>
              <p className="text-lg text-gray-700">
                Настоящие произведения искусства для оформления интерьера.
                Пилястры, багеты, балюстрады и другие детали созданы с
                тщательной проработкой каждой мелочи. Их утончённые линии и
                высококачественные материалы добавляют интерьеру изысканности и
                уникального характера. Мы стремимся сделать каждый ваш проект
                неповторимым благодаря этим деталям.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/decor.jpg"
                alt="Декор"
                className="w-full h-64 object-cover rounded-lg shadow-md "
              />
            </div>
          </div>

          <div className="flex flex-col md:flex-row-reverse items-center md:space-x-6">
            <div className="md:w-3/4 text-center md:text-left pl-5">
              <h3 className="text-xl font-bold mb-4">Корпусная мебель</h3>
              <p className="text-lg text-gray-700">
                С 2015 года мы начали производство готовой корпусной мебели,
                которая стала настоящей находкой для тех, кто ценит стиль и
                функциональность. Наши коллекции отражают последние тенденции
                мебельного дизайна и идеально вписываются в современные
                интерьеры, предоставляя возможность создать гармоничное
                пространство, отвечающее всем требованиям комфорта и красоты.
              </p>
            </div>
            <div className="md:w-1/4">
              <img
                src="src/img/furniture.jpg"
                alt="Мебель"
                className="w-full h-64 object-cover rounded-lg shadow-md"
              />
            </div>
          </div>
        </div>
      </section>
    </div>
  );
}
