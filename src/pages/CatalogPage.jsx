import React from "react";
import { Outlet, useNavigate } from "react-router-dom";

export function Catalog() {
  const navigate = useNavigate();

  return (
    <div className="bg-gray-100 min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-6 text-black">
          Каталог
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        <section className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
          <div
            className="relative group overflow-hidden rounded-lg shadow-lg cursor-pointer"
            onClick={() => navigate("facades")}
          >
            <div className="absolute top-0 left-0 w-full bg-white text-black py-2 text-center text-xl font-bold">
              Фасады
            </div>
            <img
              src="src/img/furniture.jpg"
              alt="Фасады"
              className="w-full h-full object-cover transition-transform duration-500 group-hover:scale-105"
            />
          </div>

          <div
            className="relative group overflow-hidden rounded-lg shadow-lg cursor-pointer"
            onClick={() => navigate("decor")}
          >
            <div className="absolute top-0 left-0 w-full bg-white text-black py-2 text-center text-xl font-bold">
              Декоры
            </div>
            <img
              src="src/img/furniture.jpg"
              alt="Декоры"
              className="w-full h-full object-cover transition-transform duration-500 group-hover:scale-105"
            />
          </div>

          <div className="relative group overflow-hidden rounded-lg shadow-lg">
            <div className="absolute top-0 left-0 w-full bg-white text-black py-2 text-center text-xl font-bold">
              Coming Soon
            </div>
            <div className="w-full h-full bg-gray-300 flex items-center justify-center">
              <p className="text-lg font-medium text-gray-500">Coming Soon</p>
            </div>
          </div>
          <div className="relative group overflow-hidden rounded-lg shadow-lg">
            <div className="absolute top-0 left-0 w-full bg-white text-black py-2 text-center text-xl font-bold">
              Coming Soon
            </div>
            <div className="w-full h-full bg-gray-300 flex items-center justify-center">
              <p className="text-lg font-medium text-gray-500">Coming Soon</p>
            </div>
          </div>
        </section>
        <Outlet />
      </main>
    </div>
  );
}
