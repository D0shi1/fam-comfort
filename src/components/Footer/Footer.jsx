import React from "react";
import { Link } from "react-router-dom";

export function Footer() {
  return (
    <footer className="bg-gray-800 text-white py-6">
      <div className="container mx-auto px-6">
        <div className="flex flex-col md:flex-row justify-between items-center">
          <div className="mb-4 md:mb-0">
            <Link to="/">
              <img
                src="src/img/logo.svg"
                alt="Логотип компании"
                className="w-32 h-auto"
              />
            </Link>
          </div>

          <nav className="flex space-x-4 mb-4 md:mb-0">
            <a
              href="/about"
              className="text-gray-300 hover:text-white transition-colors"
            >
              О нас
            </a>
            <a
              href="/catalog"
              className="text-gray-300 hover:text-white transition-colors"
            >
              Каталог
            </a>
            <a
              href="/contact"
              className="text-gray-300 hover:text-white transition-colors"
            >
              Контакты
            </a>
          </nav>

          <div className="flex space-x-4">
            <a href="#" className="hover:text-gray-300">
              <i className="fab fa-facebook"></i> Facebook
            </a>
            <a href="#" className="hover:text-gray-300">
              <i className="fab fa-instagram"></i> Instagram
            </a>
            <a href="#" className="hover:text-gray-300">
              <i className="fab fa-twitter"></i> Twitter
            </a>
          </div>
        </div>

        <div className="text-center mt-6 text-gray-500 text-sm">
          © {new Date().getFullYear()} ОМЦ-Профиль. Все права защищены.
        </div>
      </div>
    </footer>
  );
}
