import React from "react";
import { Link } from "react-router-dom";
import { Swiper, SwiperSlide } from "swiper/react";
import { Autoplay, Pagination, Navigation } from "swiper/modules";

import "swiper/css";
import "swiper/css/pagination";
import "swiper/css/navigation";

const slides = [
  {
    id: 1,
    title: "Уютное дополнение",
    subtitle: "современного интерьера",
    description:
      "Продукция Fam-comfort позволит создать стильное и комфортное пространство.",
    buttonText: "Каталог фасадов",
    buttonLink: "/catalog",
    image: "/img/slide1.jpg",
  },
  {
    id: 2,
    title: "Опыт на рынке и",
    subtitle: "инновационные технологии",
    description:
      "Узнайте больше информации о нашей компании и бренде Fam-comfort.",
    buttonText: "О нас",
    buttonLink: "/about",
    image: "/img/slide2.jpg",
  },
  {
    id: 3,
    title: "Сотрудничество",
    subtitle: "с нами",
    description:
      " Мы рады сотрудничеству с мебельными салонами, оптовыми организациями, интернет-магазинами, дизайнерами и другими заинтересованными юридическими лицами.",
    buttonText: "Сотрудничество",
    buttonLink: "/client",
    image: "/img/slide3.jpg",
  },
];

export const HeroSlider = () => {
  return (
    <div className="relative">
      <Swiper
        modules={[Autoplay, Pagination, Navigation]}
        spaceBetween={0}
        slidesPerView={1}
        loop={true}
        autoplay={{
          delay: 5000,
          disableOnInteraction: false,
        }}
        pagination={{
          clickable: true,
          el: ".swiper-pagination",
          type: "bullets",
        }}
        navigation={{
          nextEl: ".swiper-button-next",
          prevEl: ".swiper-button-prev",
        }}
        className="h-screen max-h-[800px]"
      >
        {slides.map((slide) => (
          <SwiperSlide key={slide.id}>
            <div
              className="h-full bg-cover bg-center text-white flex items-center"
              style={{ backgroundImage: `url(${slide.image})` }}
            >
              <div className="w-[50%] pl-[25%] pr-6 z-10">
                <div className="bg-gray-600 bg-opacity-80 p-6 rounded-lg shadow-lg w-[155%]">
                  <h1 className="text-4xl md:text-5xl font-bold mb-6">
                    {slide.title}{" "}
                    <span className="text-[#FBBD39]">{slide.subtitle}</span>
                  </h1>
                  <p className="text-lg mb-8 text-gray-200">
                    {slide.description}
                  </p>
                  <div className="flex flex-col sm:flex-row gap-4">
                    <Link
                      to={slide.buttonLink}
                      className="bg-[#FBBD39] hover:bg-[#E0A82D] text-[#1D1D1D] font-bold py-3 px-8 rounded-full transition-colors duration-300"
                    >
                      {slide.buttonText}
                    </Link>
                  </div>
                </div>
              </div>
            </div>
          </SwiperSlide>
        ))}

        <div className="swiper-pagination !bottom-8"></div>
        <div className="swiper-button-next !text-[#FBBD39] after:!text-2xl"></div>
        <div className="swiper-button-prev !text-[#FBBD39] after:!text-2xl"></div>
      </Swiper>

      <style jsx global>{`
        .swiper-pagination-bullet {
          background: white;
          opacity: 0.5;
          width: 12px;
          height: 12px;
        }
        .swiper-pagination-bullet-active {
          background: #fbbd39;
          opacity: 1;
        }
      `}</style>
    </div>
  );
};
