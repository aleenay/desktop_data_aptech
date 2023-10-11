import './App.css';
import { Button, Container } from '@mui/material'
import React from 'react';
import Card from '@mui/material/Card';

import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import img from '../src/img/cardImage.jpg'
import TextField from '@mui/material/TextField';
import Stack from '@mui/material/Stack';
import Box from '@mui/material/Box';
import Paper from '@mui/material/Paper';
import Grid from '@mui/material/Grid';
import { styled } from '@mui/material/styles';




export default function MediaCard() {
    return (
        <div>
            <Container style={{ marginTop: '10vh', display: 'flex', justifyContent: 'center' }}>
                <Card sx={{ width: 500 }}>


                    <CardContent>
                        <Stack spacing={2} direction="column">
                            <h2>Material UI </h2>

                            <TextField id="" label="Username" variant="filled" />
                            <TextField id="" label="Password" variant="filled" />

                            <Button variant="contained">Login</Button>

                        </Stack>
                    </CardContent>
                    <CardActions>
                        <Button size="small">Forgot Password?</Button>

                    </CardActions>
                </Card>


            </Container>


        </div>

    );
}

