import React, { Component } from 'react';

export class ManagerView extends Component {
  static displayName = ManagerView.name;

  constructor(props) {
    super(props);
    this.state = { reservations: [], loading: true };
  }

  componentDidMount() {
      this.fetchReservation();
  }
  render() {
    return (
      <div>
        <h1 id="tabelLabel" >Manager's View</h1>
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Client Full Name</th>
                        <th>Client Phone</th>
                        <th>Room Number</th>
                        <th>Number Of Beedroms</th>
                        <th>Check In</th>
                        <th>Check Out</th>
                        <th>Cancel</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.reservations.map(reservation =>
                        <tr key={reservation.roomId}>
                            <td>{reservation.client.fullName}</td>
                            <td>{reservation.client.phone}</td>
                            <td>{reservation.roomId}</td>
                            <td>{reservation.numberOfBeedroms}</td>
                            <td>{reservation.checkIn}</td>
                            <td>{reservation.checkOut}</td>
                            <td><button className="btn btn-danger" onClick={() => { this.cancelReservation(reservation.roomId) }}>X</button></td>
                        </tr>
                    )}
                </tbody>
            </table>
      </div>
    );
  }

  async fetchReservation() {
    const response = await fetch('api/Reservation');
    const data = await response.json();
      this.setState({ reservations: data, loading: false });
    }

   async cancelReservation(roomId) {

       console.log(roomId);
        const requestOptions = {
            method: 'DELETE',
            headers: { 'Content-Type': 'application/json' },
        };

       await fetch('api/Reservation?reservationId=' + roomId, requestOptions);
       this.fetchReservation();
    }
}
