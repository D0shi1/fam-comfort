import React from "react";
import ProductList from "../components/Catalog/ProductList"; 

const mockProducts = [
  { id: 1, name: "Фасад 1", imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEAgSGJrut6HQujoMGqZOK2kaAv1YLLSCMUA&s" },
  { id: 2, name: "Фасад 2", imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEAgSGJrut6HQujoMGqZOK2kaAv1YLLSCMUA&s" },
  { id: 3, name: "Фасад 3", imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEAgSGJrut6HQujoMGqZOK2kaAv1YLLSCMUA&s" },
  { id: 4, name: "Фасад 4", imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEAgSGJrut6HQujoMGqZOK2kaAv1YLLSCMUA&s" },
  { id: 5, name: "Фасад 5", imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEAgSGJrut6HQujoMGqZOK2kaAv1YLLSCMUA&s" },
  { id: 6, name: "Фасад 6", imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEAgSGJrut6HQujoMGqZOK2kaAv1YLLSCMUA&s" },
];

export function Facades() {
  return (
    <div className="bg-gray-100 min-h-screen flex flex-col items-center">
      <header className="py-6 w-full">
        <h1 className="text-4xl font-bold text-center mb-6 text-black">
          Фасады
        </h1>
      </header>
      <main className="container mx-auto px-6 py-10">
        <ProductList products={mockProducts} />
      </main>
    </div>
  );
}

export default Facades;
