import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Navbar, Nav, Container } from 'react-bootstrap';
import ColFlag from '../images/col_flag.png';

const Header = () => (
    <Container>
        <Navbar bg="dark" variant="dark">
            <Navbar.Brand href="/">
                <img alt="" src={ColFlag} width="35"
                    height="35"
                    className="d-inline-block align-top"
                />
                {' Algunas Vainas'}
            </Navbar.Brand>
       
            <Nav className="mr-auto">
                <Nav.Link href="/">Home</Nav.Link>
            <Nav.Link href="/about">About</Nav.Link>
        </Nav>
    </Navbar>
    </Container>
);

export default Header;