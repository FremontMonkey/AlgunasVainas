import React from "react";
import { Button, Card, CardGroup } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import '../App.css';


function PodcastCards(props) {
    return (
        <div> 
            <CardGroup>
                {
                    props.podcasts.map(p => (
                        <Card bg="light">
                            <Card.Body className="d-flex flex-column">
                                <Card.Img variant="top" style={{ width: '12rem' }} src={p.imageUrl} />
                                <Card.Title>{p.name}</Card.Title>
                                <Card.Text>{p.description}</Card.Text>
                                <Button variant="outline-primary" size="sm" >Va al Podcast</Button>
                        </Card.Body>
                        </Card>
                        )
                    )
                }
            </CardGroup>
        </div>
    );           
}

export default PodcastCards;