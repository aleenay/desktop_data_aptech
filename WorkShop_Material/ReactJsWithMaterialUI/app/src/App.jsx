import logo from './logo.svg';
import './App.css';
import { Button, Container } from '@mui/material'
import Home from './Home'
import ContactUs from './ContactUs'

import { BrowserRouter as Router, Routes, Route} from 'react-router-dom';

function App() {
  return (
   <>

 <Home/>
  {/* <Router>
    <Routes>
        <Route  path="/home" element={<Home/>} exact />
        <Route  path="/contactus" element={<ContactUs/>} exact />
       
    </Routes>
</Router> */}
   </>
    // <div className="blank">
    //   {username}
    // </div>
  );
}

export default App;
