import React, { Component } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Row, Col, Container } from 'react-bootstrap';
import '../App.css';

class About extends Component {

    render() {

        return (
            <Container>
                <Row>
                    <Col>
                        <br />
                           <h1 className="display-4">
                                About
                            </h1>
                        <h3 className="font-weight-light">About content goes here</h3>
                        </Col>
                </Row>

            </Container>
        );
    }
}


export default About;