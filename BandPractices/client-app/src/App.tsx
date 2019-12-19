import React, { Component } from 'react';
import { Header, Icon, List } from 'semantic-ui-react'
import './App.css';
import axios from 'axios';

class App extends Component {
  /* state management here */
  state = {
    values: []
  }

   /* triggering state here re-renders component */
  componentDidMount() {
    axios.get('http://localhost:5000/api/values')
      .then((response) => {
        // console.log(response);
        this.setState({
          values: response.data
          /* [{ id: 1, name: 'Value 101' }, { id: 2, name: 'Value 102' }] */
        })
      })
  }

  render() {
    return (
      <div>
        <Header as='h2'>
          <Icon name='music' />
          <Header.Content>BandPractices</Header.Content>
        </Header>
        <List>
          {this.state.values.map((value: any) =>(  /* any ignores type safety*/
                <List.Item key={value.id}>{value.name}</List.Item>
              ))}
        </List>

      </div>
    )
  }
}

export default App;
