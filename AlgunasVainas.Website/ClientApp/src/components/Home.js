import React, { Component } from 'react';
import axios from 'axios';
import PodcastCards from './PodcastCards';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Row, Col, Container } from 'react-bootstrap';
import { faPodcast } from '@fortawesome/free-solid-svg-icons';
import '../App.css';
import { library } from '@fortawesome/fontawesome-svg-core';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

library.add(faPodcast);

class Home extends Component {
    state = {
        podcasts: []
    };

    async componentDidMount() {
        await axios.get('https://bbowebapi20190422102653.azurewebsites.net/api/podcast')
            .then(response => {
                const newPodcasts = response.data.map(p => {
                    return {
                        id: p.id,
                        name: p.name,
                        imageUrl: p.imageUrl,
                        url: p.url,
                        description: p.description
                    };
                });

                const newState = Object.assign({}, this.state, {
                    podcasts: newPodcasts
                });

                this.setState(newState);
            })
            .catch(error => console.log(error));
    }

    render() {

        return (
            <Container>
                <Row>
                    <Col>
                        <br />
                        <div className="wrapper">
                            <h1 className="display-4">
                        ColombiaCasts&nbsp;<FontAwesomeIcon icon="podcast" color="#00bfff" />
                            </h1>
                           </div>
                    </Col>
                </Row>
                <Row>
                    <Col>
                        <h3 className="font-weight-light">Los mejores podcasts de Colombia. &#161;Esc&uacute;chalos!</h3>
                        <br />
                    </Col>
                </Row>
                <PodcastCards podcasts={this.state.podcasts} />
             </Container>
        );
    }
}

export default Home;