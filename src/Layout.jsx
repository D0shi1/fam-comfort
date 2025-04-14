import { Outlet } from "react-router-dom";
import { Header } from "./components/Header/header"; 
import { Footer } from "./components/Footer/Footer";

export const Layout = () => {
  return (
    <div className="min-h-screen flex flex-col">
      <Header />
      <main className="flex-grow">
        <Outlet /> {/* Здесь будут отображаться страницы */}
      </main>
      <Footer />
    </div>
  );
};
