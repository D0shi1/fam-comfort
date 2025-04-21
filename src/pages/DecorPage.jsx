import React from "react";
import ProductList from "../components/Catalog/ProductList"; 

const mockProducts = [
  { id: 1, name: "Декор 1", imageUrl: "https://via.placeholder.com/150" },
  { id: 2, name: "Декор 2", imageUrl: "https://via.placeholder.com/150" },
  { id: 3, name: "Декор 3", imageUrl: "https://via.placeholder.com/150" },
];

export function Decor() {
  return (
    <div className="bg-gray-100 min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-6 text-black">
          Декоры
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        <ProductList products={mockProducts} />
      </main>
    </div>
  );
}
