import React from "react";
import { NavLink } from "react-router-dom";
import logo from "../../img/logo.svg";

export const Header = ({ className = "" }) => {
  const NAV_ITEMS = [
    { path: "/", label: "Главная" },
    { path: "/catalog", label: "Каталог" },
    { path: "/about", label: "Где купить" },
    { path: "/clients", label: "Клиентам" },
    { path: "/about", label: "О компании" },
    { path: "/contacts", label: "Контакты" },
  ];

  return (
    <header className="bg-[#1D1D1D] shadow-xl">
      <div className="container mx-auto px-6 py-4">
        <div className="flex items-center justify-between">
          <NavLink to="/" className="flex items-center space-x-2 group">
            <img
              src={logo}
              alt="Логотип"
              className="w-16 h-16 transition-all duration-300
            transform hover:scale-110
            hover:filter hover:invert-78 hover:sepia-92 hover:saturate-856 
            hover:hue-rotate-327 hover:brightness-101 hover:contrast-92"
            />
          </NavLink>

          <nav className="hidden md:block">
            <ul className="flex space-x-6">
              {NAV_ITEMS.map((item) => (
                <li key={item.path}>
                  <NavLink
                    to={item.path}
                    className={({ isActive }) => `
                      relative px-3 py-2 text-white/90 font-medium
                      hover:text-white transition-all duration-300
                      transform hover:scale-105
                      after:content-[''] after:absolute after:bottom-0 after:left-1/2 
                      after:w-0 after:h-0.5 after:bg-[#D7B56D]
                      after:transition-all after:duration-300
                      hover:after:w-full hover:after:left-0
                      ${isActive ? "text-white" : ""}
                    `}
                  >
                    {item.label}
                  </NavLink>
                </li>
              ))}
            </ul>
          </nav>

          <div className="hidden md:flex flex-col items-end space-y-2">
            <a
              href="tel:+78001234567"
              className="flex items-center text-[#D7B56D] transition-colors transform hover:scale-105 text-xl"
            >
              <svg
                xmlns="http://www.w3.org/2000/svg"
                className="h-5 w-5 mr-2"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
              >
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth={2}
                  d="M3 5a2 2 0 012-2h3.28a1 1 0 01.948.684l1.498 4.493a1 1 0 01-.502 1.21l-2.257 1.13a11.042 11.042 0 005.516 5.516l1.13-2.257a1 1 0 011.21-.502l4.493 1.498a1 1 0 01.684.949V19a2 2 0 01-2 2h-1C9.716 21 3 14.284 3 6V5z"
                />
              </svg>
              +7 (800) 123-45-67
            </a>

            <button
              className="text-[#D7B56D] text-s font-medium transition-colors 
                      duration-300 whitespace-nowrap transform hover:scale-105 
                      after:content-[''] after:absolute after:bottom-0 after:left-1/2 
                      after:w-0 after:h-0.5 after:bg-[#D7B56D]
                      after:transition-all after:duration-300
                      hover:after:w-full hover:after:left-0"
            >
              Заказать звонок
            </button>
          </div>

          <button className="md:hidden text-white focus:outline-none">
            <svg
              className="w-6 h-6"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth={2}
                d="M4 6h16M4 12h16M4 18h16"
              />
            </svg>
          </button>
        </div>
      </div>
    </header>
  );
};
