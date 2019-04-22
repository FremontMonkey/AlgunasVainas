import React from "react";
import PropTypes from "prop-types";

function Podcast(props) {
    return (
        <div className="podcast">
            <span>{props.name}</span>
        </div>
    );
}

Podcast.propTypes = {
    name: PropTypes.string.isRequired
};

export default Podcast;