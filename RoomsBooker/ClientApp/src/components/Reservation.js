import React, { Component } from 'react';
import { Confirmation } from './Confirmation';


export class Reservation extends Component {
    static displayName = Reservation.name;

  constructor(props) {
      super(props);
      this.state = { fullName: '', phone: '', numberOfBeedroms: 1, checkIn: '', checkOut: '', roomId:0 };
  }


    render() {
        let confirmation;
        if (this.state.roomId !== 0) {
            confirmation = <Confirmation/>;
        }

    return (
        <div>
            {confirmation}
            <h1>Reservation</h1>          
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Client Full Name</th>
                        <th>Client Phone</th>
                        <th>Number Of Beedroms</th>
                        <th>Check In</th>
                        <th>Check Out</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><input type="text" class="form-control" value={this.state.fullName} onChange={event => this.setState({ fullName: event.target.value })} /></td>
                        <td><input type="tel" class="form-control" value={this.state.phone} onChange={event => this.setState({ phone: event.target.value })} /></td>
                        <td><input type="number" class="form-control" min="1" max="3" value={this.state.numberOfBeedroms} onChange={event => this.setState({ numberOfBeedroms: event.target.value })} /></td>
                        <td><input type="date" class="form-control" value={this.state.checkIn} onChange={event => this.setState({ checkIn: event.target.value })} /></td>
                        <td><input type="date" class="form-control" value={this.state.checkOut} onChange={event => this.setState({ checkOut: event.target.value })} /></td>
                        </tr>
                    
                </tbody>
            </table>

            <button className="btn btn-primary" onClick={() => { this.addReservation() }}>Ok</button>           
        </div>

 
    );
    }



    async addReservation() {
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
                id: 0,
                roomId: 0,
                checkIn: this.state.checkIn,
                checkOut: this.state.checkOut,
                numberOfBeedroms: this.state.numberOfBeedroms,
                client: {
                    fullName: this.state.fullName,
                    phone: this.state.phone
                }
            })
        };

        const response = await fetch('api/Reservation', requestOptions);

        console.log(response);
        if (response.status !== 200) {
            alert(response.statusText);


        } else {
            const response = await fetch('api/Reservation');
            const data = await response.json();
            this.setState({ currentCount: 0, fullName: '', phone: '', numberOfBeedroms: 1, checkIn: '', checkOut: '', roomId: data.roomId });
         
        }
       


    }
}
